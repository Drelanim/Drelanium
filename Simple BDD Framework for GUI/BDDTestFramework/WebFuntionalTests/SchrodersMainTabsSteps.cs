using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestCommon;
using WebFuntionalTests.PageObjects.Schroders;

namespace WebFuntionalTests
{
    [Binding]
    public class SchrodersMainTabsSteps : CommonStepMethods
    {
        public SchrodersMainTabsSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Then(@"the About Us, Insights and People tabs are present")]
        public void ThenTheAboutUsInsightsAndPeopleTabsArePresent()
        {

            // get current page
            var page = scenarioContext.Get<SchrodersStartPage>(CurrentPageKey);

            // locate the About Us tab
            try
            {
                var widget = page.LocateWidget(page.AboutUsPane);
            }
            catch (Exception e)
            {
                Assert.Fail("Could not locate About Us tab");
            }

            // locate the Insights tab
            try
            {
                var widget = page.LocateWidget(page.InsightsPane);
            }
            catch (Exception e)
            {
                Assert.Fail("Could not locate Insights tab");
            }

            // locate the People tab
            try
            {
                var widget = page.LocateWidget(page.PeoplePane);
            }
            catch (Exception e)
            {
                Assert.Fail("Could not locate People tab");
            }

        }

        [When(@"select Insights tab")]
        public void WhenSelectInsightsTab()
        {

            // get current page
            var page = scenarioContext.Get<SchrodersStartPage>(CurrentPageKey);

            // select Insights Tab
            page.LocateWidget(page.InsightsPane).Click();
        }

        [Then(@"the (.*) item is present on the (.*) menu")]
        public void ThenTheItemIsPresentOnTheMostRecentMenu(string itemName, string menuName)
        {

            // get current page
            var page = scenarioContext.Get<SchrodersStartPage>(CurrentPageKey);

            // locate the menu item
            try
            {
                var itemWidget = page.GetMenuItem(page.InsightsPullDownMenu, page.InsightsPullDownMenuItem, menuName, itemName);
            }
            catch (Exception e)
            {
                Assert.Fail($"Could not locate menu item {itemName} of menu {menuName}");
            }         
        }
    }

}
