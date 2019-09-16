using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.TestRunHooks
{
    [Binding]
    public class BeforeTestRunHooks : BaseBindingClass
    {
        public BeforeTestRunHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [BeforeTestRun(Order = 1)]
        public static void BeforeTestRun1()
        {
        }
    }
}