﻿using Drelanium.BDD;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.ScenarioBlockHooks
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