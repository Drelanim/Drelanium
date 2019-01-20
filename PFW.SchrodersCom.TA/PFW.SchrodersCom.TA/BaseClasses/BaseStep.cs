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



        public IWebDriver StartWebDriver()
        {
            IWebDriver driver;

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





        public void SaveCurrentPage(BasePage page)
        {
            CurrentPage = (BasePage)page;
            scenarioContext.Set(CurrentPage, CurrentPageKey);
        }

        public BasePage GetCurrentPage()
        {
           return scenarioContext.Get<BasePage>(CurrentPageKey);
        }

        public void NavigateToCurrentPage()
        {
            scenarioContext.Set(CurrentPage, CurrentPageKey);
        }

                                 

























    }
}
