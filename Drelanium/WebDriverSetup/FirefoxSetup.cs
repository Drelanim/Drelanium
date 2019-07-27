using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;


namespace Drelanium.WebDriverConfiguration
{

    public static class FirefoxSetup
    {

        private static FirefoxOptions CreateFirefoxOptions(HeadlessMode headlessMode, string[] driverOptionsArguments = null)
        {
            var options = new FirefoxOptions();

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

        public static IWebDriver StartFirefox(DriverConfiguration driverConfiguration)
        {
            var options = CreateFirefoxOptions(driverConfiguration.HeadlessMode, driverConfiguration.DriverOptionsArguments);

            switch (driverConfiguration.TestMode)
            {
                case TestMode.LOCAL:
                    return new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

                case TestMode.REMOTE:
                    return new RemoteWebDriver(new Uri(driverConfiguration.SeleniumGridHubUrl), options);

                default:
                    throw new InvalidEnumArgumentException();
            }
        }

    }

}