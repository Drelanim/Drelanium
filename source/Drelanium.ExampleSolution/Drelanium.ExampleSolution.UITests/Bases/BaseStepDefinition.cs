using TechTalk.SpecFlow;

// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.UITests
{
    public abstract class BaseStepDefinition
    {
        protected BaseStepDefinition(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
        {
            TestThreadContext = testThreadContext;
            FeatureContext = featureContext;
            ScenarioContext = scenarioContext;
        }

        public TestThreadContext TestThreadContext { get; }
        public FeatureContext FeatureContext { get; }
        public ScenarioContext ScenarioContext { get; }
    }
}