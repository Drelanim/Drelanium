using System;
using BoDi;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings.Reflection;

namespace XUnitTestProject.BaseClasses
{
    public class BaseStepDefinition : BaseBindingClass
    {
        public BaseStepDefinition(
            TestThreadContext testThreadContext,
            FeatureContext featureContext,
            ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
        }

        public IObjectContainer TestThreadContainer => TestThreadContext.TestThreadContainer;

        public IObjectContainer FeatureContainer => FeatureContext.FeatureContainer;

        public IObjectContainer ScenarioContainer => ScenarioContext.ScenarioContainer;

        public FeatureInfo FeatureInfo => FeatureContext.FeatureInfo;

        public ScenarioInfo ScenarioInfo => ScenarioContext.ScenarioInfo;

        public StepInfo StepInfo => StepContext.StepInfo;

        public string StepName => StepInfo.StepDefinitionType + " " + StepInfo.Text;

        public IBindingMethod StepDefinitionMethod => StepInfo.BindingMatch.StepBinding.Method;

        public ScenarioBlock CurrentScenarioBlock => ScenarioContext.CurrentScenarioBlock;

        public ScenarioExecutionStatus ScenarioExecutionStatus => ScenarioContext.ScenarioExecutionStatus;

        public Exception ScenarioError => ScenarioContext.TestError;

        public void NotImplementedStepDefinition()
        {
            throw new NotImplementedException(
                $"StepDefinition implementation in method {StepDefinitionMethod} is incomplete for \n" +
                $"Feature: {FeatureInfo.Title} \n" +
                $"Scenario: {ScenarioInfo.Title} \n" +
                $"Step: {StepName}",
                new PendingStepException());
        }
    }
}