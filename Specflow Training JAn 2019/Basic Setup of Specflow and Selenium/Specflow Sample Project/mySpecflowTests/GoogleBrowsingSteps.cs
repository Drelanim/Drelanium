using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace mySpecflowTests
{
    [Binding]
    public class GoogleBrowsingSteps
    {
        [Given(@"Google is launched on url (.*)")]
        public void GivenGoogleIsLaunchedOnUrl(string url)
        {
            IWebDriver webdriver = null;
            try
            {
                // setup chrome driver
                webdriver = new ChromeDriver(@"C:\seleniumDrivers");
                // for each browser we have a separate driver....
                // IWebDriver webdriver = new InternetExplorerDriver(@"C:\seleniumDrivers");

                // setup driver for full screen and implicit timeout
                webdriver.Manage().Window.FullScreen();
                webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                // navigate to url
                webdriver.Navigate().GoToUrl(url);

                // and we click the English button
                // var widget = webdriver.FindElement(By.XPath($"//a[@title=\"English\"]"));
                // widget.Click();

                // leave screen up to see navigation
                Thread.Sleep(3000);
                webdriver.Quit();
            }
            catch(Exception e)

            {
                webdriver.Quit();
                throw new Exception(e.Message);
            }
        }
    }
}
