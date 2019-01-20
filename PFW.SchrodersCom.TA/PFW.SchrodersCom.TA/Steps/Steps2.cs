using OpenQA.Selenium;
using PFW.SchrodersCom.TA.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Steps
{
    [Binding]
    class Steps2 : BaseStep
    {

        public Steps2(IWebDriver driver, ScenarioContext scenarioContext) : base(scenarioContext) => Driver = driver;


        [When(@"I fill out the userform on the page")]
        public void WhenIFillOutTheUserformOnThePage()
        {

        }

        [Then(@"The userform is filled out")]
        public void ThenTheUserformIsFilledOut()
        {

        }





    }
}
