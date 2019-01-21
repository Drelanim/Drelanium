using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using PFW.SchrodersCom.TA.BaseClasses;
using PFW.SchrodersCom.TA.Steps;
using System;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Steps
{
    [Binding]
    public class Hooks : BaseStep
    {
        private readonly IObjectContainer _objectContainer;

                              
        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext) : base(scenarioContext) => _objectContainer = objectContainer;



        [BeforeScenario]
        public void Initialize ()
        {
            Driver = StartWebDriver();
            _objectContainer.RegisterInstanceAs<RemoteWebDriver>(Driver);
        }


        [AfterScenario]
        public void CleanUp()
        {
            Driver.Quit();
        }





    }
}






