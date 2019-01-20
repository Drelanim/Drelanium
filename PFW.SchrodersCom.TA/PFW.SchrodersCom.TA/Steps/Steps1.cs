using OpenQA.Selenium;
using PFW.SchrodersCom.TA.BaseClasses;
using PFW.SchrodersCom.TA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Steps
{
    [Binding]
    class Steps1 : BaseStep
    {

        public Steps1(IWebDriver driver, ScenarioContext scenarioContext) : base(scenarioContext) => Driver = driver;


        [Scope(Feature = "Login specific feature")]
        [Given(@"I am on the EA Login Page")]
        public void GivenIAmOnTheEALoginPage()
        {
            EALoginPage ea = new EALoginPage(Driver);
            scenarioContext[CurrentPageKey] = ea;
            

        }

        
        [When(@"I type my username and password")]
        public void WhenITypeMyUsernameAndPassword()
        {

            var page = scenarioContext.Get<EALoginPage>(CurrentPageKey);
            

        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {

        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {

        }





    }
}
