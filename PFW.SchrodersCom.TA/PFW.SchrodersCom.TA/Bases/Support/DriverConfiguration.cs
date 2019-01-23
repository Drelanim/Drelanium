using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace PFW.SchrodersCom.TA.Bases.Support
{
    public static class DriverConfiguration
    {

        public static RemoteWebDriver StartWebDriver()
        {
            switch (TestMode)
            {
                case testmodeLOCAL:
                    switch (Browser)
                    {
                        case browserCHROME:
                            return new ChromeDriver(ChromeOptions);
                        case browserFIREFOX:
                            return new FirefoxDriver(FirefoxOptions);
                        case browserINTERNETEXPLORER:
                            return new InternetExplorerDriver(InternetExplorerOptions);
                        default:
                            throw new Exception();
                    }
                case testmodeREMOTE:
                    switch (Browser)
                    {
                        case browserCHROME:
                            return new RemoteWebDriver(SeleniumGridUri, ChromeOptions.ToCapabilities());
                        case browserFIREFOX:
                            return new RemoteWebDriver(SeleniumGridUri, FirefoxOptions.ToCapabilities());
                        case browserINTERNETEXPLORER:
                            return new RemoteWebDriver(SeleniumGridUri, ChromeOptions.ToCapabilities());
                        default:
                            throw new Exception();
                    }
                default:
                    throw new Exception();
            }
        }

        private const string keyEnvironment = "Environment";
        private const string keySYS1Domain = "SYS1Domain";
        private const string keyUATDomain = "UATDomain";
        private const string keyPRODDomain = "PRODDomain";
        private const string keyTestMode = "TestMode";
        private const string keySeleniumGridHubUrl = "SeleniumGridHubUrl";
        private const string keyBrowser = "Browser";
        private const string keyHeadlessMode = "HeadlessMode";
        private const string browserCHROME = "CHROME";
        private const string browserFIREFOX = "FIREFOX";
        private const string browserINTERNETEXPLORER = "INTERNETEXPLORER";
        private const string envSYS1 = "SYS1";
        private const string envUAT = "UAT";
        private const string envPROD = "PROD";
        private const string headlessmodeON = "ON";
        private const string headlessmodeOFF = "OFF";
        private const string testmodeLOCAL = "LOCAL";
        private const string testmodeREMOTE = "REMOTE";


        private static string Environment => ConfigurationManager.AppSettings[keyEnvironment];
        private static string SYS1Domain => ConfigurationManager.AppSettings[keySYS1Domain];
        private static string UATDomain => ConfigurationManager.AppSettings[keyUATDomain];
        private static string PRODDomain => ConfigurationManager.AppSettings[keyPRODDomain];
        private static string TestMode => ConfigurationManager.AppSettings[keyTestMode];
        private static string SeleniumGridHubUrl => ConfigurationManager.AppSettings[keySeleniumGridHubUrl];
        private static string Browser => ConfigurationManager.AppSettings[keyBrowser];
        private static string HeadlessMode => ConfigurationManager.AppSettings[keyHeadlessMode];
        private static string Domain => SelectDomain(Environment);
        private static ChromeOptions ChromeOptions => CreateChromeOptions(HeadlessMode);
        private static FirefoxOptions FirefoxOptions => CreateFirefoxOptions(HeadlessMode);
        private static InternetExplorerOptions InternetExplorerOptions => CreateInternetExplorerOptions();
        private static Uri SeleniumGridUri => new Uri(SeleniumGridHubUrl);

        private static string SelectDomain (string environment)
        {
            switch (environment)
            {
                case envSYS1:
                    return SYS1Domain;
                case envUAT:
                    return UATDomain;
                case envPROD:
                    return PRODDomain;
                default:
                    throw new Exception();
            }
        }

        private static ChromeOptions CreateChromeOptions(string headlessmode)
        {
            ChromeOptions options = new ChromeOptions();

            switch (headlessmode)
            {
                case headlessmodeON:
                    options.AddArgument("--headless");
                    break;
                case headlessmodeOFF:
                    break;
                default:
                    throw new Exception();
            }
            return options;
        }

        private static FirefoxOptions CreateFirefoxOptions(string headlessmode)
        {
            FirefoxOptions options = new FirefoxOptions();

            switch (headlessmode)
            {
                case headlessmodeON:
                    options.AddArgument("--headless");
                    break;
                case headlessmodeOFF:
                    break;
                default:
                    throw new Exception();
            }
            return options;
        }

        private static InternetExplorerOptions CreateInternetExplorerOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IgnoreZoomLevel = true;
            return options;
        }

    }
}
