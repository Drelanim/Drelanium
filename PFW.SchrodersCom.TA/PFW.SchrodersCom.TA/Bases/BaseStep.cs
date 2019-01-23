using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Bases
{

    public class BaseStep
    {


        public IWebDriver Driver { get; set; }

        public ScenarioContext ScenarioContext { get; }

        public BaseStep(ScenarioContext scenarioContext) => ScenarioContext = scenarioContext;


















    }
}
