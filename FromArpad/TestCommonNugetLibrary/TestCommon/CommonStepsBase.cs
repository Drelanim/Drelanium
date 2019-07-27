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

        [Then(@"http status code in response (.*) equals (.*)")]
        public void ThenHttpStatusCodeInResponseEquals(string resultsPayloadKey, int httpStatusCode)
        {
            var resultsPayload = scenarioContext.Get<Dictionary<string, object>>(resultsPayloadKey);
            Assert.AreEqual(httpStatusCode, resultsPayload["HttpStatusCode"], "Unexpected  Http Status Code in PayPal response");
        }

    }
}
