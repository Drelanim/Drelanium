using TechTalk.SpecFlow;
using Drelanium.BDD;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class AfterScenarioBlockHooks : BaseBindingClass
    {
        public AfterScenarioBlockHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [AfterScenarioBlock(Order = 1)]
        public void AfterScenarioBlock1()
        {
        }
    }
}