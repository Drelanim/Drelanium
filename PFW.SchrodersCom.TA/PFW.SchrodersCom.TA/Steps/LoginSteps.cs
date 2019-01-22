using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using PFW.SchrodersCom.TA.BaseClasses;
using PFW.SchrodersCom.TA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Steps
{
    [Binding]
    [Scope(Feature = "Login specific feature")]
    class LoginSteps : BaseStep
    {

        public LoginSteps(RemoteWebDriver driver, ScenarioContext scenarioContext) :base(scenarioContext) => Driver = driver;

 



        [Given(@"I am on the EA Login Page")]
        public void GivenIAmOnTheEALoginPage()
        {
            SetCurrentPageAndNavigateToIt<EALoginPage>();
            Console.WriteLine("1. Step Run perfectly");
        }

        [When(@"I type my username and password")]
        public void WhenITypeMyUsernameAndPassword()
        {
            LoadCurrentPage<EALoginPage>().FillEALoginPageFields();
            Console.WriteLine("2. Step Run perfectly");
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            LoadCurrentPage<EALoginPage>().ClickLogin();
            Console.WriteLine("3. Step Run perfectly");
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            AssertThatCurrentPageIsLoaded<EALoginPage>();


        }












    }
}
