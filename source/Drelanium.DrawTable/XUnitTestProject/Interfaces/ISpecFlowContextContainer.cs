using TechTalk.SpecFlow;

namespace XUnitTestProject
{
    public interface ISpecFlowContextContainer
    {
        TestThreadContext TestThreadContext { get; }

        FeatureContext FeatureContext { get; }

        ScenarioContext ScenarioContext { get; }

        ScenarioStepContext StepContext { get; }
    }
}