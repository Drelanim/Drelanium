using System;
using System.Threading;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Setup
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private readonly ScenarioContext _scenarioContext;

        


        //public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        //{
        //    _objectContainer = objectContainer;
        //    _scenarioContext = scenarioContext;
        //}


        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }








        public static IWebDriver StartWebDriver(BrowserType browserType)
        {
            IWebDriver driver;

            switch (browserType)
            {
                case BrowserType.Chrome:
                    driver = new ChromeDriver(ChromeSetup.CreateOptions());
                    break;
                case BrowserType.Firefox:
                    driver = new FirefoxDriver(FirefoxSetup.CreateOptions());
                    break;
                case BrowserType.InternetExplorer:
                    driver = new InternetExplorerDriver(InternetExplorerSetup.CreateOptions());
                    break;
                default:
                    throw new Exception();
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;

        }






        [BeforeScenario]
        public void Initialize ()
        {

            
            
            _driver = StartWebDriver(BrowserType.InternetExplorer);
            _scenarioContext.Set<IWebDriver>(_driver,"Driver");
            // _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);



        }

        [AfterScenario]
        public void CleanUp()
        {
            _driver.Quit();
            Console.WriteLine(_scenarioContext.ScenarioInfo.Title);
            Console.WriteLine(_scenarioContext.TestError);
          
        }





    }
}






