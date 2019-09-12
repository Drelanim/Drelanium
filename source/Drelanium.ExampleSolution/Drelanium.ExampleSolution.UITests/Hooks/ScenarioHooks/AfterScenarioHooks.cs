﻿using Drelanium.BDD;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.ScenarioHooks
{
    [Binding]
    public class AfterScenarioHooks : BaseBindingClass
    {
        public AfterScenarioHooks(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        [AfterScenario(Order = 1)]
        public void AfterScenario1()
        {
        }
    }
}