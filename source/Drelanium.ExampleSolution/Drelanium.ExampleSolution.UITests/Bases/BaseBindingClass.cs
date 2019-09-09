using OpenQA.Selenium;
using TechTalk.SpecFlow;

// ReSharper disable IdentifierTypo

namespace Drelanium.ExampleSolution.UITests
{
    public abstract class BaseBindingClass
    {
        protected BaseBindingClass(
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

        public IWebDriver Driver
        {
            get => TestThreadContext.Get<IWebDriver>();
            set => TestThreadContext.Set(value);
        }

        public BasePageObject CurrentPage
        {
            get => TestThreadContext.Get<BasePageObject>();
            set => TestThreadContext.Set(value);
        }
    }
}