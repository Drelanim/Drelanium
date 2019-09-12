using Drelanium.BDD;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class AfterFeatureHooks : BaseBindingClass
    {
        public AfterFeatureHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [AfterFeature(Order = 1)]
        public static void AfterFeature1(
            TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {
            testThreadContext.Get<IWebDriver>().Quit();
        }
    }
}