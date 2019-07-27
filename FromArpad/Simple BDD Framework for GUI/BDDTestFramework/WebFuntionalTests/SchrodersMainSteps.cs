using TestCommon;
using System.Configuration;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WebFuntionalTests.PageObjects.Schroders;

namespace PlanetWinE2ETests
{
    [Binding]
    public class SchrodersMainSteps : CommonStepMethods
    {
        public SchrodersMainSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [When(@"bring up main page")]
        [Given(@"bring up main page")]
        public void GivenBringUpMainPage()
        {
            //get browser type
            var browserType = scenarioContext.Get<string>(BrowserTypeKey);

            // navigate to Planetwin main page
            string websiteurl = ConfigurationManager.AppSettings["SchrodersUrl"];
            var page = NavigateToWebPage<SchrodersStartPage>(websiteurl, browserType);

        }

        [When(@"bring up the Show Me page via button")]
        public void WhenBringUpTheShowMePageViaButton()
        {
            // get current page
            var page = scenarioContext.Get<SchrodersStartPage>(CurrentPageKey);

            // press Show Me button
            var widget = page.LocateWidget(page.ShowMeButton);
            widget.Click();

            // switch to Show Me page object as current 
            SwitchCurrentPageObjectTo<SchrodersShowMePage>();
        }

        [Then(@"all of the Show Me page link containers are present")]
        public void ThenAllOfTheShowMePageLinkContainersArePresent()
        {
            // get current page
            var page = scenarioContext.Get<SchrodersShowMePage>(CurrentPageKey);

           // locate AboutUS container and validate text of its links
           var widget = page.LocateWidget(page.AboutUsContainer);
           string expectedAboutUsContainerText = "About us\r\nWelcome to Schroders\r\nOur story\r\nOur business\r\nCorporate responsibility\r\nOur new identity";
           Assert.AreEqual(expectedAboutUsContainerText, widget.Text, "About Us container texts incorrect");

            // locate CazenoveCapital container and validate text of its links
           var widget1 = page.LocateWidget(page.CazenoveCapitalContainer);
            string expectedCazenoveCapitalText = "Cazenove Capital\r\nAbout us\r\nOur services\r\nContact us";
            Assert.AreEqual(expectedCazenoveCapitalText, widget1.Text, "CazenoveCapital container texts incorrect");

            // locate FollowUs container and validate text of its links
            var widget2 = page.LocateWidget(page.FollowUsContainer);
            string expectedFollowUsContainerText = "Follow us\r\nTwitter\r\nLinkedIn\r\nYouTube";
            Assert.AreEqual(expectedFollowUsContainerText, widget2.Text, "Follow Us container texts incorrect");

            // locate Insights container and validate text of its links
            var widget3 = page.LocateWidget(page.InsightsContainer);
            string expectedInsightsContainerText = "Insights\r\nEconomics\r\nWatch/Listen\r\nGlobal Investor Study\r\nBrexit\r\nInvestment Outlooks 2019\r\ninvestIQ";
            Assert.AreEqual(expectedInsightsContainerText, widget3.Text, "Insights container texts incorrect");

            // locate InvestorRelations container and validate text of its links
            var widget4 = page.LocateWidget(page.InvestorRelationsContainer);
            string expectedInvestorRelationsContainerText = "Investor Relations\r\nHomepage\r\nResults, reports & presentations\r\nAnnual Report & Accounts 2017";
            Assert.AreEqual(expectedInvestorRelationsContainerText, widget4.Text, "Investor Relations container texts incorrect");

            // locate MediaRelations container and validate text of its links
            var widget5 = page.LocateWidget(page.MediaRelationsContainer);
            string expectedMediaRelationsContainerText = "Media Relations\r\nHomepage\r\nNewsroom\r\nMedia contacts";
            Assert.AreEqual(expectedMediaRelationsContainerText, widget5.Text, "Media Relations container texts incorrect");

            // locate PeopleContainer container and validate text of its links
            var widget6 = page.LocateWidget(page.PeopleContainer);
            string expectedPeopleContainerContainerText = "People\r\nOur people\r\nWorking here\r\nStarting out\r\nExperienced professionals\r\nDiversity and Inclusion\r\nApplicant Privacy Policy";
            Assert.AreEqual(expectedPeopleContainerContainerText, widget6.Text, "People Container container texts incorrect");

            // locate StrategicCapabilities container and validate text of its links
            var widget7 = page.LocateWidget(page.StrategicCapabilitiesContainer);
            string expectedStrategicCapabilitiesContainerText = "Strategic capabilities\r\nCapabilities\r\nRetirement\r\nSustainability\r\nLiquid Alternatives\r\nCredit\r\nEmerging Markets\r\nPrivate Assets\r\nSolutions\r\nIncome\r\nMulti-Asset Solutions\r\nAlpha Equity";
            Assert.AreEqual(expectedStrategicCapabilitiesContainerText, widget7.Text, "Strategic Capabilities container texts incorrect");

        }

        [Given(@"press the search button and let the search page come up")]
        public void GivenPressTheSearchButtonAndLetTheSearchPageComeUp()
        {
            // get current page
            var page = scenarioContext.Get<SchrodersStartPage>(CurrentPageKey);

            // press Show Me button
            var widget = page.LocateWidget(page.SearchButton);
            widget.Click();

            // switch to Show Me page object as current 
            SwitchCurrentPageObjectTo<SchrodersSearchPage>();

        }

        [When(@"submitting a search for text (.*)")]
        public void WhenSubmittingASearchForText(string searchText)
        {
            // get current page
            var page = scenarioContext.Get<SchrodersSearchPage>(CurrentPageKey);

            // enter search text
            page.LocateWidget(page.searchBox).SendKeys(searchText);

            // press search button
            page.LocateWidget(page.searchButton).Click();

        }

        [Then(@"the search fails with (.*)")]
        public void ThenTheSearchFailsWith(string expectedErrorText)
        {
            // get current page
            var page = scenarioContext.Get<SchrodersSearchPage>(CurrentPageKey);

            // get actual error text and assert it
            int maxWaitSecondsForSearchResult = 30;
            var widget = page.LocateWidget(page.notFoundParagraph, maxWaitSecondsForSearchResult);
            Assert.AreEqual(expectedErrorText, widget.Text, "search error text incorrect");

        }

    }
}
