using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestCommon
{
    public class SeleniumPageBase
    {
        // default webdriver wait object timeout in seconds
        private const int _webDriverWaitTimeout = 15;

        // property to hold selenium remote driver reference
        private RemoteWebDriver _driver;
        public RemoteWebDriver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        // constructor for the case when we are just changing page object but driver already present 
        public SeleniumPageBase(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        // constructor, requires browser option object to intialize remote driver
        public SeleniumPageBase(object browserOptions)
        {
            Uri seleniumGridUri = new Uri(ConfigurationManager.AppSettings["SeleniumHubUrl"]);

            if (browserOptions is FirefoxOptions)
            {
                Driver = new RemoteWebDriver(seleniumGridUri, ((FirefoxOptions)browserOptions).ToCapabilities());
            }
            else if (browserOptions is ChromeOptions)
            {
                Driver = new RemoteWebDriver(seleniumGridUri, ((ChromeOptions)browserOptions).ToCapabilities());
            }
            else if (browserOptions is InternetExplorerOptions)
            {
                Driver = new RemoteWebDriver(seleniumGridUri, ((InternetExplorerOptions)browserOptions).ToCapabilities());
            }
            else if (browserOptions is EdgeOptions)
            {
                Driver = new RemoteWebDriver(seleniumGridUri, ((EdgeOptions)browserOptions).ToCapabilities());
            }
            else
            {
                throw new Exception("Unknown browser options type encountered ");
            }
        }
            

        // wait for alert
        public IAlert WaitForAlert(int waitSeconds)
        {
            float pollIntervalMilisecs = 500;
            int maxPolls = (int)(waitSeconds / (pollIntervalMilisecs / 1000));
            IAlert alert = null;
            for (int i = 0; i <= maxPolls; i++)
            {
                try
                {
                    alert = Driver.SwitchTo().Alert();
                    return alert;
                }
                catch (Exception ex)
                {
                    Thread.Sleep((int)pollIntervalMilisecs);
                    continue;
                }
            }

            throw new Exception("pop up Alert wait timeout ");
        }

        // locate a widget using WebDriverWait instead of ImplicitlyWait
        // use retry approach to common stale element exception
        public IWebElement LocateWidget(By locator, int webDriverWaitTimeout = _webDriverWaitTimeout)
        {
            int retries = 0;
            int MAX_RETRIES = 10;
            var waitObj = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(webDriverWaitTimeout));
            while (true)
            {
                try
                {
                    waitObj.Until(ExpectedConditions.ElementIsVisible(locator));
                    return this.Driver.FindElement(locator);
                }
                catch (WebDriverTimeoutException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("The HTTP request to the remote WebDriver server for URL"))
                    {
                        throw new Exception("Fatal Webdriver error in LocateWidget: " + e.Message);
                    }
                    if (retries < MAX_RETRIES)
                    {
                        retries++;
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
                        throw new Exception("Gave up retries in LocateWidget: " + e.GetType());
                    }
                }
            }
        }

        // locate widget and get its text value
        public string LocateWidgetAndGetValue(By locator, int webDriverWaitTimeout = _webDriverWaitTimeout)
        {
            IWebElement widget = LocateWidget(locator, webDriverWaitTimeout);
            return widget.GetAttribute("value");
        }

        // click in widget area relative to its top left corner
        // used when the widget has no Click method but can be located
        public IWebElement ClickWidgetRelative(By locator, int XOffset = 5, int YOffset = 5, int webDriverWaitTimeout = _webDriverWaitTimeout)
        {
            IWebElement widget = LocateWidget(locator, webDriverWaitTimeout);
            Actions action = new Actions(Driver);
            action.MoveToElement(widget, XOffset, YOffset).Click().Build().Perform();
            return widget;
        }

        // click on widget using WebDriverWait instead of ImplicitlyWait
        // use retry approach to common stale element exception
        public void ClickWidget(By locator, int webDriverWaitTimeout = _webDriverWaitTimeout)
        {
            int retries = 0;
            int MAX_RETRIES = 10;
            var waitObj = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(webDriverWaitTimeout));
            while (true)
            {
                try
                {
                    IWebElement widget = waitObj.Until((ExpectedConditions.ElementToBeClickable(locator)));
                    widget.Click();

                    return;
                }
                catch (WebDriverTimeoutException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("The HTTP request to the remote WebDriver server for URL"))
                    {
                        throw new Exception("Fatal Webdriver error in ClickWidget: " + e.Message);
                    }
                    if (retries < MAX_RETRIES)
                    {
                        retries++;
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
                        throw new Exception("Gave up retries in ClickWidget: " + e.GetType());
                    }
                }
            }
        }

        // click on widget and retry clicks until able to locate specified new widget
        // used when a click is missed by the page or the webriver
        public IWebElement ClickWidgetAndLocateNext(By locator, By newLocator, int webDriverWaitTimeout = _webDriverWaitTimeout)
        {
            int waitRetries;
            int clickRetries;
            int MAX_WAIT_OBJ_RETRIES = 10;
            int MAX_CLICK_RETRIES = 3;
            var waitObj = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(webDriverWaitTimeout));

            // try until success or retry count reached
            clickRetries = 0;
            while (true)
            {
                // click the first widget 
                waitRetries = 0;
                while (true)
                {
                    try
                    {
                        IWebElement widget = waitObj.Until((ExpectedConditions.ElementToBeClickable(locator)));
                        widget.Click();

                        // all OK, proceed to locating second widget
                        break;
                    }
                    catch (WebDriverTimeoutException e)
                    {
                        // wait object timeout exception, abandon
                        throw e;
                    }
                    catch (Exception e)
                    {
                        if (e.Message.Contains("The HTTP request to the remote WebDriver server for URL"))
                        {
                            throw new Exception("Fatal Webdriver error in ClickWidgetAndLocateNext: " + e.Message);
                        }
                        // other exception, such as stale widget etc. worth continuing wait for
                        if (waitRetries < MAX_WAIT_OBJ_RETRIES)
                        {
                            waitRetries++;
                            Thread.Sleep(1000);
                            continue;
                        }
                        else
                        {
                            // max retries expired, abandon
                            throw new Exception("Gave up locating widget in ClickWidgetAndLocateNext: " + e.GetType());
                        }
                    }
                }

                // locate second widget until success or retry count reached
                waitRetries = 0;
                while (true)
                {
                    try
                    {
                        IWebElement widget = waitObj.Until((ExpectedConditions.ElementIsVisible(locator)));
                        // all OK, return with element 
                        //return this.Driver.FindElement(newLocator);
                        return widget;
                    }
                    catch (WebDriverTimeoutException e)
                    {
                        // wait object timeout exception, retrying original click in case it was missed
                        break;
                    }
                    catch (Exception e)
                    {
                        if (e.Message.Contains("The HTTP request to the remote WebDriver server for URL"))
                        {
                            throw new Exception("Fatal Webdriver error in ClickWidgetAndLocateNext: " + e.Message);
                        }
                        if (waitRetries < MAX_WAIT_OBJ_RETRIES)
                        {
                            // other exception, such as stale widget etc. worth continuing wait for
                            waitRetries++;
                            Thread.Sleep(1000);
                            continue;
                        }
                        else
                        {
                            // retrying original click
                            break;
                        }
                    }
                }

                // repeat until click retries max reached
                clickRetries++;
                if (clickRetries >= MAX_CLICK_RETRIES)
                {
                    throw new Exception("Gave up click retries in ClickWidgetAndLocateNext");
                }
            }
        }


        // locate pulldown menu and select item by index
        public IWebElement selectByIndexFromPulldown(By locator, int index, int webDriverWaitTimeout = _webDriverWaitTimeout)
        {

            int maxRetries = 10;
            bool maxRetriesExpired = true;
            IWebElement widget = null;
            var waitObj = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(webDriverWaitTimeout));

            for (var i = 0; i < maxRetries; i++)
            {

                try
                {
                    // locate widget
                    widget = waitObj.Until((ExpectedConditions.ElementToBeClickable(locator)));

                    // wait for AJAX to load menu items
                    WaitForAjax();

                    // cast widget to selector element and select the item 
                    var selectorWidget = new SelectElement(widget);
                    selectorWidget.SelectByIndex(index);

                    // set success flag and break
                    maxRetriesExpired = false;
                    break;
                }
                catch (WebDriverTimeoutException e)
                {
                    // wait object timeout exception, abandon
                    throw e;
                }
                catch (Exception e)
                {
                    if (e.Message.Contains("The HTTP request to the remote WebDriver server for URL"))
                    {
                        throw new Exception("Fatal Webdriver error in selectByIndexFromPulldown: " + e.Message);
                    }
                    // other exception, such as stale widget etc. worth retrying for

                    // pause and retry
                    Thread.Sleep(1000);
                }
            }
            // throw exception if max tries expired
            if (maxRetriesExpired)
            {
                throw new Exception("Gave up click retries in selectByIndexFromPulldown");
            }

            // return wiht pulldown menu web element object reference
            return widget;

        }

        // select and click on a div menu item
        public void SelectDivMenuItem(By menuLocator, By itemLocator)
        {
            var element = Driver.FindElement(menuLocator);
            Actions action = new Actions(Driver);
            action.MoveToElement(element).Perform();
            Driver.FindElement(itemLocator).Click();
        }

        // wait for Ajax to load method, logs a warning on timeout
        // returns false on timeout
        public Boolean WaitForAjax()
        {
            // wait up to 10 seconds for AJAX to load menu items
            int maxRetries = 20;
            bool LoadWaitExpired = true;
            for (var i = 0; i < maxRetries; i++)
            {
                var ajaxIsComplete = (bool)(Driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                {
                    LoadWaitExpired = false;
                    break;
                }
                Thread.Sleep(500);
            }
            if (LoadWaitExpired)
            {
                return false;
            }
            return true;
        }
    }
}
