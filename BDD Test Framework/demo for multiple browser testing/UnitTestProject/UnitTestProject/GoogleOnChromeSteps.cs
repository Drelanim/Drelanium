using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace UnitTestProject
{
    [Binding]
    public class GoogleOnChromeSteps
    {
        [Given(@"I start Chrome, navigate to Google and search for WebDriver")]
        public void GivenIStartChromeNavigateToGoogleAndSearchForWebDriver()
        {
            ChromeOptions Options = new ChromeOptions();
            // InternetExplorerOptions Options = new InternetExplorerOptions();
            //FirefoxOptions Options = new FirefoxOptions();
            // EdgeOptions Options = new EdgeOptions();

            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), Options.ToCapabilities(), TimeSpan.FromSeconds(600));// NOTE: connection timeout of 600 seconds or more required for time to launch grid nodes if non are available.

            try
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://www.google.com/ncr");
                IWebElement query = driver.FindElement(By.Name("q"));
                query.SendKeys("webdriver");
                query.Submit();
                Thread.Sleep(1000);
                driver.Quit();
            }
            catch (Exception e)
            {
                driver.Quit();
                Assert.Fail("test failed");
            }
        }
    }
}
