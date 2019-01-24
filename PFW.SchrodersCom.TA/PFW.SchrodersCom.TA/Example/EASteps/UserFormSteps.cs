using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using PFW.SchrodersCom.TA.Bases.EAExample.EAPages;
using PFW.SchrodersCom.TA.Bases.Support;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Bases.EAExample.EASteps
{

    [Scope(Feature = "EAExample_Userform specific feature")]
    [Binding]
    class UserFormSteps : BaseStep
    {

        public UserFormSteps(RemoteWebDriver driver, ScenarioContext scenarioContext) : base(scenarioContext) => Driver = driver;



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

        [When(@"I fill out the userform on the page")]
        public void WhenIFillOutTheUserformOnThePage(Table table)
        {
            CommonSteps.LoadCurrentPage<EAUserFormPage>(this).FillFields(table);
            
        }


        [Then(@"The Fields Are filled")]
        public void ThenTheFieldsAreFilled()
        {
            var page = CommonSteps.LoadCurrentPage<EAUserFormPage>(this);

            Assertions.AssertThatTextboxIsNotEmpty(page.TxtFirstName);
            Assertions.AssertThatTextboxIsNotEmpty(page.TxtInitial);
            Assertions.AssertThatTextboxIsNotEmpty(page.TxtMiddleName);
        }












    }
}
