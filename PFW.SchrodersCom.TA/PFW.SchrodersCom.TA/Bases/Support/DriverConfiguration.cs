﻿using System;
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




        public static string SelectedEnvironment()
        {  
            return ConfigurationManager.AppSettings["Environment"];
        }

        public static string SelectedBrowser()
        {
            return ConfigurationManager.AppSettings["Browser"];
        }

        public static string SelectedHeadlessMode()
        {
            return ConfigurationManager.AppSettings["HeadlessMode"];
        }


        public static RemoteWebDriver StartWebDriver()
        {

            RemoteWebDriver driver;

            switch (SelectedBrowser())
            {
                case "CHROME":
                    driver = new ChromeDriver(CreateChromeOptions());
                    break;
                case "FIREFOX":
                    driver = new FirefoxDriver(CreateFirefoxOptions());
                    break;
                case "INTERNETEXPLORER":
                    driver = new InternetExplorerDriver(CreateInternetExplorerOptions());
                    break;
                default:
                    throw new Exception();
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            return driver;
        }


        public static ChromeOptions CreateChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();

            switch (SelectedHeadlessMode())
            {
                case "ON":
                    options.AddArgument("--headless");
                    break;
                case "OFF":
                    break;
                default:
                    throw new Exception();
            }
            return options;
        }

        public static FirefoxOptions CreateFirefoxOptions()
        {
            FirefoxOptions options = new FirefoxOptions();

            switch (SelectedHeadlessMode())
            {
                case "ON":
                    options.AddArgument("--headless");
                    break;
                case "OFF":
                    break;
                default:
                    throw new Exception();
            }
            return options;
        }


        public static InternetExplorerOptions CreateInternetExplorerOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IgnoreZoomLevel = true;
            return options;
        }




    }
}
