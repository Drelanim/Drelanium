using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
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


        }


    }
}
