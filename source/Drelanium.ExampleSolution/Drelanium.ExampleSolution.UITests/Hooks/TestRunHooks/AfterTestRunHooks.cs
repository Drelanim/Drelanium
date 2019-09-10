using TechTalk.SpecFlow;
using Drelanium.BDD;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class AfterTestRunHooks : BaseBindingClass
    {
        public AfterTestRunHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [AfterTestRun(Order = 1)]
        public static void AfterTestRun1()
        {
        }
    }
}