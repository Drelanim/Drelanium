using TechTalk.SpecFlow;
using Drelanium.BDD;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class AfterScenarioHooks : BaseBindingClass
    {
        public AfterScenarioHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [AfterScenario(Order = 1)]
        public void AfterScenario1()
        {
        }
    }
}