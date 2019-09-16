﻿using System;
using TechTalk.SpecFlow;

namespace Drelanium.ExampleSolution.UITests.Hooks.StepHooks
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
            StepStopWatch.Stop();

            Logger?.Information(
                $"Elapsed time in the Step: {Math.Round(StepStopWatch.Elapsed.TotalSeconds, 2)} seconds");
        }
    }
}