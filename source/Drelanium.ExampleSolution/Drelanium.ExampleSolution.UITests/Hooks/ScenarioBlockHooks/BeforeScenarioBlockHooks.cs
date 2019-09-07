using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class BeforeScenarioBlockHooks : BaseBindingClass
    {
        public BeforeScenarioBlockHooks(
               TestThreadContext testThreadContext,
               FeatureContext featureContext,
               ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }


        [BeforeScenarioBlock(Order = 1)]
        public void BeforeScenarioBlock1()
        {


        }





    }
}
