using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Schroders.com_UI_TA
{
    [Binding]
    public class Hooks
    {
        
        [BeforeScenario]
        public void InitializeWebDriver()
        {
            BrowserType browserType = BrowserType.InternetExplorer;
            ScenarioContext.Current.Add("Driver", WebDriverSetup.StartWebDriver(browserType));
        }



        [AfterScenario]
        public void QuitWebDriver()
        {
            ScenarioContext.Current.Get<IWebDriver>("Driver").Quit();
        }
    }
}
