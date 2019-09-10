using TechTalk.SpecFlow;
using Drelanium.BDD;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class BeforeScenarioHooks : BaseBindingClass
    {
        public BeforeScenarioHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [BeforeScenario(Order = 1)]
        public void BeforeScenario1()
        {
        }
    }
}