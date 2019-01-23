using OpenQA.Selenium;
using PFW.SchrodersCom.TA.Bases.EAExample.EAPages;
using PFW.SchrodersCom.TA.Bases.Support;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Bases.EAExample.EASteps
{
    [Binding]
    [Scope(Feature = "EAExample_Login specific feature")]
    class LoginSteps : BaseStep
    {

        public LoginSteps(IWebDriver driver, ScenarioContext scenarioContext) :base(scenarioContext) => Driver = driver;








        [Given(@"I am on the EA Login Page")]
        public void GivenIAmOnTheEALoginPage()
        {
            CommonSteps.CreateANewPageAndSaveItToCurrentPageAndNavigateTo<EALoginPage>(this);
        }

        [When(@"I type my username and password")]
        public void WhenITypeMyUsernameAndPassword()
        {
            CommonSteps.LoadCurrentPage<EALoginPage>(this).FillFields();
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            CommonSteps.LoadCurrentPage<EALoginPage>(this).Login();
            CommonSteps.CreateANewPageAndSaveItToCurrentPage<EAUserFormPage>(this);
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            var element = CommonSteps.LoadCurrentPage<EAUserFormPage>(this).TxtInitial;
            Assertions.AssertThatWebElementIsDisplayed(element);
        }












    }
}
