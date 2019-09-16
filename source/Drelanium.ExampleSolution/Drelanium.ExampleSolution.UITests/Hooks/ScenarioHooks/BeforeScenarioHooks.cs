using System.Diagnostics;
using Serilog;
using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace Drelanium.ExampleSolution.UITests.Hooks.ScenarioHooks
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
        public void BeforeScenario1(ITestOutputHelper testOutputHelper)
        {
            Logger = new LoggerConfiguration()
                .WriteTo
                .TestOutput(testOutputHelper)
                .CreateLogger();
        }

        [BeforeScenario(Order = 2)]
        public void BeforeScenario2()
        {
            ScenarioStopwatch = new Stopwatch();
            ScenarioStopwatch.Start();
        }
    }
}