using System.Collections.Generic;
using NUnit.Framework;
using TechTalk.SpecFlow;



namespace TestCommon
{
    [Binding]
    public class CommonStepsBase: CommonStepMethods
    {
        public CommonStepsBase(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Given(@"Browser type is (.*)")]
        public void GivenBrowserTypeEquals(string browserType)
        {
            scenarioContext.Set(browserType, BrowserTypeKey);
        }

        [Given(@"Headless Mode is (.*)")]
        public void HeadlessModeON(bool isHeadless)
        {
            scenarioContext.Set(isHeadless, HeadlessModeKey);
        }

        [StepArgumentTransformation(@"(ON|OFF)")]
        public bool OnOffToBool(string value)
        {
            return value == "ON";
        }

    }
}
