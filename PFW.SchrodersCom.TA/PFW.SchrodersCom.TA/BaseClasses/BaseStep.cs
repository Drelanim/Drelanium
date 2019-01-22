using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Linq;
using System.Configuration;
using OpenQA.Selenium.Remote;
using NUnit.Framework;

namespace PFW.SchrodersCom.TA.BaseClasses
{

    public abstract class BaseStep : Base
    {

        public readonly ScenarioContext scenarioContext;


        public BaseStep(ScenarioContext scenarioContext) :base() => this.scenarioContext = scenarioContext;



        public string SelectedEnvironment()
        {
                return ConfigurationManager.AppSettings["Environment"];
        }

        public string SelectedBrowser()
        {
            return ConfigurationManager.AppSettings["Browser"];
        }

        public string SelectedHeadlessMode()
        {
            return ConfigurationManager.AppSettings["HeadlessMode"];
        }



        public RemoteWebDriver StartWebDriver()
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }


        public ChromeOptions CreateChromeOptions()
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

        public FirefoxOptions CreateFirefoxOptions()
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

        public InternetExplorerOptions CreateInternetExplorerOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IgnoreZoomLevel = true;
            return options;
        }


        public void SaveCurrentPage<T>(T page)
        {
            scenarioContext.Set(page, CurrentPageKey);
        }

        public T LoadCurrentPage<T>()
        {
            return scenarioContext.Get<T>(CurrentPageKey);
        }

        public string LoadCurrentPageUrl<T>()
        {
           T page = LoadCurrentPage<T>();
           return page.GetType().GetProperty("PageUrl").GetValue(page, null) as string;
        }


        public void NavigateToCurrentPage<T>()
        {
            string url = LoadCurrentPageUrl<T>();
            Driver.Navigate().GoToUrl(url);
        }

        public T SetCurrentPageAndNavigateToIt<T>()
        {
            T page = CreateANewPage<T>();
            NavigateToCurrentPage<T>();
            SaveCurrentPage(page);
            return page;
        }

        public void CheckIfGoodPageIsLoaded<T>()
        {
            string urlLoaded = Driver.Url;
            string currentPageUrl = LoadCurrentPageUrl<T>();
            Assert.AreEqual(urlLoaded, currentPageUrl);
        }

        public void AssertThatGoodPageIsLoaded<T>()
        {
           
            

        }










    }
}
