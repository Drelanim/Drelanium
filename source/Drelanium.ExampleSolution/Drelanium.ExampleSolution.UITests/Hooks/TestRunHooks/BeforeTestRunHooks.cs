using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.FeatureHooks
{
    public class BeforeTestRunHooks : BaseBindingClass
    {
        public BeforeTestRunHooks(
               TestThreadContext testThreadContext,
               FeatureContext featureContext,
               ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }



        [BeforeTestRun(Order = 1)]
        public static void BeforeTestRun1(
            TestThreadContext testThreadContext,
            FeatureContext featureContext)
        {


        }



    }
}
