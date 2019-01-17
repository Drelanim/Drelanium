using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Schroders.com_UI_TA.Setup;

namespace Schroders.com_UI_TA
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        InternetExplorer
    }

    public static class WebDriverSetup
    {
        public static IWebDriver StartWebDriver(BrowserType browserType)
        {
            IWebDriver Driver;

            switch (browserType)
            {
                case BrowserType.Chrome:
                    Driver = new ChromeDriver(ChromeSetup.CreateOptions());
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver(FirefoxSetup.CreateOptions());
                    break;
                case BrowserType.InternetExplorer:
                    Driver = new InternetExplorerDriver(InternetExplorerSetup.CreateOptions());
                    break;
                default:
                    throw new Exception();
            }

            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return Driver;
        }


    }
}
