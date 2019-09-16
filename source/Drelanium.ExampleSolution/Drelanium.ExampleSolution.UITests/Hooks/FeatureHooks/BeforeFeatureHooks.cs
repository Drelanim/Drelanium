using System.Diagnostics;
using System.IO;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class BeforeFeatureHooks : BaseBindingClass
    {
        public BeforeFeatureHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [BeforeFeature(Order = 1)]
        public static void BeforeFeature1(
            TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {
            testThreadContext.Set(new Stopwatch(), nameof(TestThreadStopWatch));
            testThreadContext.Get<Stopwatch>(nameof(TestThreadStopWatch)).Start();
        }

        [BeforeFeature(Order = 2)]
        public static void BeforeFeature2(
            TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {
            featureContext.Set(new Stopwatch(), nameof(FeatureStopwatch));
            featureContext.Get<Stopwatch>(nameof(FeatureStopwatch)).Start();
        }

        [BeforeFeature(Order = 3)]
        public static void BeforeFeature3(
            TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {
            var driver = DriverInitializer.StartWebDriver(
                ExecutionMode.LOCAL,
                BrowserType.CHROME,
                new ChromeOptions(),
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            testThreadContext.Set(driver, "Driver");
        }
    }
}