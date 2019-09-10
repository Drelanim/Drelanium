using Drelanium;
using OpenQA.Selenium;
using Serilog.Core;
using TechTalk.SpecFlow;

namespace XUnitTestProject.BaseClasses
{


    public class BaseSeleniumTestStepDefinition : BaseStepDefinition
    {
        public BaseSeleniumTestStepDefinition(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {


        }

      




        public IWebDriver Driver
        {

            get => TestThreadContext.Get<IWebDriver>();
            set => TestThreadContext.Set(value);
        }


        public IPageObject CurrentPage
        {
            get => ScenarioContext.Get<IPageObject>();
            set => ScenarioContext.Set(value);
        }


        public IWebElement FocusedWebElement => Driver.SwitchTo().ActiveElement();





        public Logger Logger
        {
            get => TestThreadContext.Get<Logger>();
            set => TestThreadContext.Set(value);
        }

   
    }
}