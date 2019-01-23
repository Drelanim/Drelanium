using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;

namespace PFW.SchrodersCom.TA.Bases
{

    public class BaseStep
    {


        public RemoteWebDriver Driver { get; set; }

        public ScenarioContext ScenarioContext { get; }

        public BaseStep(ScenarioContext scenarioContext) => ScenarioContext = scenarioContext;


















    }
}
