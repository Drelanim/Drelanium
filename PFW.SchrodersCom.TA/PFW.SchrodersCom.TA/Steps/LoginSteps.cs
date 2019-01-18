using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PFW.SchrodersCom.TA.Steps
{
    [Binding]
    class LoginSteps
    {
        //private IWebDriver _driver;

        //public LoginSteps(IWebDriver driver) => _driver = driver;


        private ScenarioContext _scenarioContext;

        public LoginSteps(ScenarioContext scenarioContext) => _scenarioContext = scenarioContext;








        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {

            
            _driver.Navigate().GoToUrl(@"http://executeautomation.com/demosite/Login.html");

        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            _driver.FindElement(By.Name("UserName")).SendKeys((String)data.UserName);
            _driver.FindElement(By.Name("Password")).SendKeys((String)data.Password);

        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            _driver.FindElement(By.Name("Login")).Submit();
            
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            var element = _driver.FindElement(By.Name("Initial"));
            Assert.That(element, Is.Not.Null, "Header text not found!!!");

        }








    }
}
