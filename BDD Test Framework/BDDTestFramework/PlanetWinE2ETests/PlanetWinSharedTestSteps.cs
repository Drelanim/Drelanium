using System;
using System.Configuration;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using PlanetWinE2ETests.PageObjects;
using TechTalk.SpecFlow;
using TestCommon;


namespace PlanetWinE2ETests
{
    [Binding]
    public partial class PlanetWinSharedTestSteps : CommonStepMethods
    {
        public PlanetWinSharedTestSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [When(@"login to PlanetWin with following data")]
        [Given(@"login to PlanetWin with following data")]
        public void WhenLoginToPlanetWinWithFollowingData(Table table)
        {
            //get browser type
            var browserType = scenarioContext.Get<string>(BrowserTypeKey);

            // get inout parameters tologin
            string username = null;
            string password = null;
            string language = null;
            table.Rows.FirstOrDefault().TryGetValue("username", out username);
            table.Rows.FirstOrDefault().TryGetValue("password", out password);
            table.Rows.FirstOrDefault().TryGetValue("language", out language);

            // navigate to Planetwin main page
            string websiteurl = ConfigurationManager.AppSettings["PlanetWin365Url"];
            var page = NavigateToWebPage<PlanetWin365StartPage>(websiteurl, browserType);

            // call login page method
            page.Login(username: username, password: password, language: language);
        }

        [Given(@"login to PlanetWin with default user credentials")]
        public void GivenLoginToPlanetWinWithDefaultUserCredentials()
        {
            //get browser type
            var browserType = scenarioContext.Get<string>(BrowserTypeKey);

            // navigate to Planetwin main page
            string websiteurl = ConfigurationManager.AppSettings["PlanetWin365Url"];
            var page = NavigateToWebPage<PlanetWin365StartPage>(websiteurl, browserType);

            // call login page method
            page.Login(username: Planet365DefaultUsername, password: Planet365DefaultPassword);
        }

        [Then(@"verify username on account data tab")]
        [Given(@"verify username on account data tab")]
        public void ThenVerifyUserNameOnAccountTabAgainstDefaultUser()
        {
            VerifyUserNameOnAccountTabAgainstUsername(null);
        }

        [Then(@"verify username on account data tab against username (.*)")]
        [Given(@"verify username on account data tab against username (.*)")]
        public void ThenVerifyUserNameOnAccountTabAgainstDefaultUser(string username)
        {
            VerifyUserNameOnAccountTabAgainstUsername(username);
        }

        public void VerifyUserNameOnAccountTabAgainstUsername(string username)
        {
            // get current page
            var page = scenarioContext.Get<PlanetWin365UserDetailsPage>(CurrentPageKey);

            // read username and raise exception if not found or incorrect
            try
            {
                var actualUsername = page.LocateWidget(page.usernameField, 25).GetAttribute("value");
                var expectedUsername = (username == null)? Planet365DefaultUsername : username;
                Assert.AreEqual(expectedUsername, actualUsername, $"Unexpected username {actualUsername}");
            }
            catch (Exception ex)
            {
                //  assert test case fail
                Assert.Fail("username field not found");
            }
        }

        [When(@"logged in and selecting the account data tab")]
        [Given(@"logged in and selecting the account data tab")]
        public void loggedInAndSelectingTheAccountDataTab()
        {

            // switch to user details page as current page in context and return it
            var userDetailsPage = SwitchCurrentPageObjectTo<PlanetWin365UserDetailsPage>();

            // verify logged in condition
            try
            {
                userDetailsPage.LocateWidget(userDetailsPage.logoutBtn);
            }
            catch (Exception ex)
            {
                //  assert test case fail
                Assert.Fail("Login unsuccessful");
            }


            // select AccountTab
            try
            {
                userDetailsPage.ClickWidget(userDetailsPage.accountTab);
            }
            catch (Exception ex)
            {
                //  assert test case fail
                Assert.Fail("USER DATA tab not found or inactive");
            }
        }

        [Then(@"verify logged in condition")]
        public void ThenVerifyLoggedInCondition()
        {

            // switch to user details page as current page in context and return it
            var userDetailsPage = SwitchCurrentPageObjectTo<PlanetWin365UserDetailsPage>();

            // verify logged in condition
            try
            {
                userDetailsPage.LocateWidget(userDetailsPage.logoutBtn);
            }
            catch (Exception ex)
            {
                //  assert test case fail
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail($"Login unsuccessful - {ex.Message}");
            }
        }

        [Then(@"verify access denied popup presented within (.*) seconds with alert text (.*)")]
        public void ThenVerifyAccessDeniedPopup(int popupWaitSeconds, string expectedAlertText)
        {

            // get current page
            var page = scenarioContext.Get<PlanetWin365StartPage>(CurrentPageKey);

            // verify alert
            IAlert alert = null;
            try
            {
                alert = page.WaitForAlert(popupWaitSeconds);
            }
            catch (Exception ex)
            {
                //  assert test case fail
                var errmsg = $"No alert message detected on invalid credentials within {popupWaitSeconds} seconds";
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Fail(errmsg);
            }

            // check alert text
            char[] charsToTrim = { ' ' };
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedAlertText, alert.Text.Trim(charsToTrim), $"Unexpected Alert text {alert.Text}");
        }
    }
}
