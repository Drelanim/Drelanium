using System;
using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestCommon;
using WebFuntionalTests.PageObjects;

namespace WebFuntionalTests
{
    [Binding]
    public class GoogleBrowsingSteps : CommonStepMethods
    {
        public GoogleBrowsingSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Given(@"Google is launched on url (.*)")]
        public void GivenGoogleIsLaunchedOnUrl(string url)
        {
            //get browser type
            var browserType = scenarioContext.Get<string>(BrowserTypeKey);

            // navigate to Planetwin main page
            var page = NavigateToWebPage<GoogleStartPage>(url, browserType);

            var widget = page.LocateWidget(page.searchField);
            widget.SendKeys("hello\n");

            // leave browser up a bit
            Thread.Sleep(3000);

        }
    }
}
