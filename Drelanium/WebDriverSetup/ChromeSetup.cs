using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;


namespace Drelanium.WebDriverConfiguration
{

    public static class ChromeSetup
    {

        private static ChromeOptions CreateChromeOptions(HeadlessMode headlessMode, string[] driverOptionsArguments = null)
        {
            var options = new ChromeOptions();

            options.AddAdditionalCapability("useAutomationExtension", false);

            if (headlessMode == HeadlessMode.ON)
            {
                options.AddArgument("--headless");
            }

            if (driverOptionsArguments != null)
            {
                options.AddArguments(driverOptionsArguments);
            }

            return options;
        }

        public static IWebDriver StartChrome(DriverConfiguration driverConfiguration)
        {
            var options = CreateChromeOptions(driverConfiguration.HeadlessMode, driverConfiguration.DriverOptionsArguments);

            switch (driverConfiguration.TestMode)
            {
                case TestMode.LOCAL:
                    return new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

                case TestMode.REMOTE:
                    return new RemoteWebDriver(new Uri(driverConfiguration.SeleniumGridHubUrl), options);

                default:
                    throw new InvalidEnumArgumentException();
            }
        }

    }

}