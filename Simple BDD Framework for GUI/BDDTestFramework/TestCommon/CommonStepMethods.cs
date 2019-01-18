using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.Extensions;
using TechTalk.SpecFlow;

namespace TestCommon
{
    [Binding]
    public class CommonStepMethods
    {
        // common scenario context keys
        public static string CurrentPageKey = "CurrentPageKey";
        public static string BrowserTypeKey = "BrowserTypeKey";
        public static string HeadlessModeKey = "HeadlessModeKey";

        // scenario context
        public readonly ScenarioContext scenarioContext;

        public CommonStepMethods(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }

        [AfterScenario]
        private void DoAfterScenario()
        {
            // check for page object and return of not found
            SeleniumPageBase page;
            try
            {
                page = scenarioContext.Get<SeleniumPageBase>(CurrentPageKey);
            }
            catch (Exception e)
            {
                return;
            }


            // take screenshot if test failed
            if (scenarioContext.TestError != null)
            {
                // setup snapshot directory
                Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
                string snapshotDir = System.IO.Directory.GetCurrentDirectory() + "\\..\\..\\..\\Test_Fail_Screenshots";
                System.IO.Directory.CreateDirectory(snapshotDir);

                // from date time stamp tat is conpatible with filename chars
                DateTime now = DateTime.Now;
                string dateTimeStamp = String.Format("{0:D}-{1:D}-{2:D} {3:D}.{4:D}.{5:D}.{6:D}", now.Year, now.Month,
                    now.Day, now.Hour, now.Minute, now.Second, now.Millisecond);

                // sanitize scenario title to use in filename
                var scenarioTitle = scenarioContext.ScenarioInfo.Title;
                Regex illegalInFileName = new Regex(@"[\\/:*?""<>|]");
                scenarioTitle = illegalInFileName.Replace(scenarioTitle, "");

                // take screenshot
                try
                {
                    var screenshot = page.Driver.TakeScreenshot();
                    screenshot.SaveAsFile($"{snapshotDir}\\{scenarioTitle} {dateTimeStamp}.png");
                }
                catch (Exception e)
                {
                    // snapshot usually fails if there is a popup alert present
                    page.Driver.Quit();
                    Console.WriteLine($"Sanpshot failed - {e.Message}");
                    return;
                }
            }

            // stop Web Driver attached to the page object
            page.Driver.Quit();

        }


        // navigates to web page, returns a page object derived from SeleniumPageBase
        public T NavigateToWebPage<T>(string pageUrl, string browserType)
        {
            // get headless mode setting
            var isHeadless = false;
            if (scenarioContext.Keys.Contains("HeadlessModeKey"))
            {
                isHeadless = scenarioContext.Get<bool>(HeadlessModeKey);
            }

            // setup arguments for page object, i.e. browser options and url, to pass on to page constructor
            T page = default(T);
            object[] args = new object[2];
            args[1] = pageUrl;
            switch (browserType)
            {
                case "CHROME":
                    {
                        var options = new ChromeOptions();
                        if (isHeadless)
                        {
                            options.AddArguments("--headless");
                        }
                        args[0] = options;
                        break;
                    }
                case "IE":
                    {
                        args[0] = new InternetExplorerOptions();
                        break;
                    }
                case "FIREFOX":
                    {
                        var options = new FirefoxOptions();
                        if (isHeadless)
                        {
                            options.AddArguments("--headless");
                        }
                        args[0] = options;
                        break;
                    }
                case "EDGE":
                    {
                        args[0] = new EdgeOptions();
                        break;
                    }
                default:
                    {
                        Assert.Fail($"unknown browser type {browserType}");
                        break;
                    }
            }

            try
            {
                // create page and navigate to it. The page must be derived from SeleniumPageBase
                // and contain browser options and start url parameters in its constructor
                page = (T)Activator.CreateInstance(typeof(T), args);

                // set to max screen
                ((SeleniumPageBase)(object)page).Driver.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                Assert.Fail($"Failed to initialize Webdriver - {e}");
            }

            // store current page in context
            SeleniumPageBase pageToContext = (SeleniumPageBase)(object)page;
            scenarioContext.Set(pageToContext, CurrentPageKey);

            // return the page object
            return page;
        }

        // this method takes the current page object type and creates new page object using the old one's driver
        // and returns the new page object to the caller
        public T SwitchCurrentPageObjectTo<T>()
        {
            var oldPage = scenarioContext.Get<SeleniumPageBase>(CurrentPageKey);
            object[] args = new object[1];
            args[0] = oldPage.Driver;
            var newPage = (T)Activator.CreateInstance(typeof(T), args);
            SeleniumPageBase pageToContext = (SeleniumPageBase)(object)newPage;
            scenarioContext.Set(pageToContext, CurrentPageKey);
            return newPage;
        }
    }
}
