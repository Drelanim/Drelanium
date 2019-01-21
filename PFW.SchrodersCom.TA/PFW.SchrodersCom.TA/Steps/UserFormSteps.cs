using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using PFW.SchrodersCom.TA.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Steps
{

    [Scope(Feature = "Userform specific feature")]
    [Binding]
    class UserFormSteps : BaseStep
    {

        public UserFormSteps(RemoteWebDriver driver, ScenarioContext scenarioContext) : base(scenarioContext) => Driver = driver;



        [Given(@"I am on the EA Login Page")]
        public void GivenIAmOnTheEALoginPage()
        {
              
        }

        [When(@"I type my username and password")]
        public void WhenITypeMyUsernameAndPassword()
        {
              
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
              
        }

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
