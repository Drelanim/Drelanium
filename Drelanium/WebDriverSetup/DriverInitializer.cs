using System;
using System.ComponentModel;
using OpenQA.Selenium;


namespace Drelanium.WebDriverConfiguration
{

    public static class DriverInitializer
    {

        public static IWebDriver StartWebDriver(DriverConfiguration driverConfiguration, TimeSpan implicitWaitTimeout, TimeSpan pageLoadTimeout)
        {
            IWebDriver driver;

            switch (driverConfiguration.BrowserType)
            {
                case BrowserType.CHROME:
                    driver = ChromeSetup.StartChrome(driverConfiguration);
                    break;

                case BrowserType.FIREFOX:
                    driver = FirefoxSetup.StartFirefox(driverConfiguration);
                    break;

                case BrowserType.INTERNETEXPLROER:
                    driver = InternetExplorerSetup.StartInternetExplorer(driverConfiguration);
                    break;

                default:
                    throw new InvalidEnumArgumentException();
            }

            driver.Manage().Timeouts().ImplicitWait = implicitWaitTimeout;
            driver.Manage().Timeouts().PageLoad = pageLoadTimeout;

            return driver;
        }

    }

}