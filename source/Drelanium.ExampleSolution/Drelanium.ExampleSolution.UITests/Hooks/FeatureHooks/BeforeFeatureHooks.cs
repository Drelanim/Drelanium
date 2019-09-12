using System.IO;
using System.Reflection;
using Drelanium.BDD;
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
            var driver = DriverInitializer.StartWebDriver(
                ExecutionMode.LOCAL,
                BrowserType.CHROME,
                new ChromeOptions(),
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            testThreadContext.Set(driver);
        }
    }
}