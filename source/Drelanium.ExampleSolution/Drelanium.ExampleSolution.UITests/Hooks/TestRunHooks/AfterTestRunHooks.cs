﻿using Drelanium.BDD;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.TestRunHooks
{
    [Binding]
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
        public static void AfterTestRun1()
        {
        }
    }
}