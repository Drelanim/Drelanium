using TechTalk.SpecFlow;

namespace XUnitTestProject.BaseClasses
{
    public class BaseBindingClass : ISpecFlowContextContainer
    {
        public BaseBindingClass(
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

        public ScenarioStepContext StepContext => ScenarioContext.StepContext;
    }
}