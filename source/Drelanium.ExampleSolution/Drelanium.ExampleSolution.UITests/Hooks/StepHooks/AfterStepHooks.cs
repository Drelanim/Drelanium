using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    [Binding]
    public class AfterStepHooks : BaseBindingClass
    {
        public AfterStepHooks(
               TestThreadContext testThreadContext,
               FeatureContext featureContext,
               ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [AfterStep(Order = 1)]
        public void AfterStep1()
        {


        }




    }
}
