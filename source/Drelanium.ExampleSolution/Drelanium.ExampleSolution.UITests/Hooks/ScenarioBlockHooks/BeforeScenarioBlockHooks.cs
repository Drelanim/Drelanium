using TechTalk.SpecFlow;
using Drelanium.BDD;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class BeforeScenarioBlockHooks : BaseBindingClass
    {
        public BeforeScenarioBlockHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [BeforeScenarioBlock(Order = 1)]
        public void BeforeScenarioBlock1()
        {
        }
    }
}