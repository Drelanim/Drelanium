using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;


namespace Drelanium.WebDriverConfiguration
{

    public static class InternetExplorerSetup
    {

        private static InternetExplorerOptions CreateInternetExplorerOptions(string[] driverOptionsArguments = null)
        {
            var options = new InternetExplorerOptions();

            if (driverOptionsArguments == null)
            {
                return options;
            }

            if (driverOptionsArguments.Contains("EnableNativeEvents"))
            {
                options.EnableNativeEvents = true;
            }

            if (driverOptionsArguments.Contains("IgnoreZoomLevel"))
            {
                options.IgnoreZoomLevel = true;
            }

            return options;
        }

        public static IWebDriver StartInternetExplorer(DriverConfiguration driverConfiguration)
        {
            var options = CreateInternetExplorerOptions(driverConfiguration.DriverOptionsArguments);

            switch (driverConfiguration.TestMode)
            {
                case TestMode.LOCAL:
                    return new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

                case TestMode.REMOTE:
                    return new RemoteWebDriver(new Uri(driverConfiguration.SeleniumGridHubUrl), options);

                default:
                    throw new InvalidEnumArgumentException();
            }
        }

    }

}