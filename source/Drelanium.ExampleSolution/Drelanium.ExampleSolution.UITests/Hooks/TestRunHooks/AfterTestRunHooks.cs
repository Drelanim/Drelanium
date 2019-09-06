using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    public class AfterTestRunHooks : BaseBindingClass
    {
        public AfterTestRunHooks(
               TestThreadContext testThreadContext,
               FeatureContext featureContext,
               ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }



        [AfterTestRun(Order = 1)]
        public static void AfterTestRun1(
            TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {


        }


    }
}
