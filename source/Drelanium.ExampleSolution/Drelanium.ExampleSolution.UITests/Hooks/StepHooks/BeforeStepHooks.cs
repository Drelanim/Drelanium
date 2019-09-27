using System.Diagnostics;
using Drelanium.BDD;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.StepHooks
{
    [Binding]
    public class BeforeStepHooks : BaseBindingClass
    {
        public BeforeStepHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [BeforeStep(Order = 1)]
        public void BeforeStep1()
        {
            StepStopWatch = new Stopwatch();
            StepStopWatch.Start();
        }
    }
}