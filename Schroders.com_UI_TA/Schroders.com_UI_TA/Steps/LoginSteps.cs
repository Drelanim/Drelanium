using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Schroders.com_UI_TA.Setup;
using Schroders.com_UI_TA.Pages;
using OpenQA.Selenium;



namespace Schroders.com_UI_TA.Steps
{
    
    [Binding]
    class LoginSteps
    {

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            ScenarioContext.Current.Get<IWebDriver>("Driver").Navigate().GoToUrl(new GlobalHomePage(TestEnvironment.PROD).Url);
            string url = new GlobalHomePage(TestEnvironment.PROD).Url;
            ScenarioContext.Current.Get<IWebDriver>("Driver").Navigate().GoToUrl(new GlobalHomePage(TestEnvironment.PROD).Url);
            Console.WriteLine("I navigate to application");
        }

        [When(@"I enter username and password")]
        public void WhenIEnterUsernameAndPassword(Table table)
        {
            Console.WriteLine("Enter username and password");
        }

        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            Console.WriteLine("Click login");
        }

        [Then(@"I should see user logged in the application")]
        public void ThenIShouldSeeUserLoggedInTheApplication()
        {
            Console.WriteLine("I logged in");
        }
               

    }
}
