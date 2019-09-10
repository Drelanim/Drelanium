using System;
using BoDi;
using JetBrains.Annotations;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings.Reflection;

namespace Drelanium.BDD
{
    /// <summary>
    ///     Base for classes, that has <see cref="BindingAttribute" /> on it, and holds methods with
    ///     <see cref="GivenAttribute" /> | <see cref="WhenAttribute" /> | <see cref="ThenAttribute" /> attributes.
    /// </summary>
    public abstract class BaseStepDefinition : BaseBindingClass
    {
        /// <summary>
        ///     <inheritdoc cref="BaseStepDefinition" />
        /// </summary>
        /// <param name="testThreadContext">Context object, that can be used during the usage of the TestThread.</param>
        /// <param name="featureContext">Context object, that can be used during the execution of the Feature.</param>
        /// <param name="scenarioContext">Context object, that can be used during the execution of the Scenario.</param>
        protected BaseStepDefinition(
            [NotNull] TestThreadContext testThreadContext,
            [NotNull] FeatureContext featureContext,
            [NotNull] ScenarioContext scenarioContext)
            : base(testThreadContext, featureContext, scenarioContext)
        {
            if (testThreadContext == null) throw new ArgumentNullException(nameof(testThreadContext));
            if (featureContext == null) throw new ArgumentNullException(nameof(featureContext));
            if (scenarioContext == null) throw new ArgumentNullException(nameof(scenarioContext));
        }

        /// <summary>
        ///     <see cref="IObjectContainer" /> object, that can be used during the usage of the TestThread.
        /// </summary>
        public IObjectContainer TestThreadContainer => TestThreadContext.TestThreadContainer;

        /// <summary>
        ///     <see cref="IObjectContainer" /> object, that can be used during the usage of the Feature.
        /// </summary>
        public IObjectContainer FeatureContainer => FeatureContext.FeatureContainer;

        /// <summary>
        ///     <see cref="IObjectContainer" /> object, that can be used during the usage of the Scenario.
        /// </summary>
        public IObjectContainer ScenarioContainer => ScenarioContext.ScenarioContainer;

        /// <summary>
        ///     <see cref="TechTalk.SpecFlow.FeatureInfo" /> object, that can be used to retrieve info about the currently executed
        ///     Feature.
        /// </summary>
        public FeatureInfo FeatureInfo => FeatureContext.FeatureInfo;

        /// <summary>
        ///     <see cref="TechTalk.SpecFlow.ScenarioInfo" /> object, that can be used to retrieve info about the currently
        ///     executed Scenario.
        /// </summary>
        public ScenarioInfo ScenarioInfo => ScenarioContext.ScenarioInfo;

        /// <summary>
        ///     <see cref="TechTalk.SpecFlow.StepInfo" /> object, that can be used to retrieve info about the currently executed
        ///     Step.
        /// </summary>
        public StepInfo StepInfo => StepContext.StepInfo;

        /// <summary>
        ///     The full name of the currently executed Step.
        /// </summary>
        public string StepName => StepInfo.StepDefinitionType + " " + StepInfo.Text;

        /// <summary>
        ///     The StepDefinition method, that has been bound to the currently executed Step.
        /// </summary>
        public IBindingMethod StepDefinitionMethod => StepInfo.BindingMatch.StepBinding.Method;

        /// <summary>
        ///     The execution status of the currently executed Scenario.
        /// </summary>
        public ScenarioExecutionStatus ScenarioExecutionStatus => ScenarioContext.ScenarioExecutionStatus;

        /// <summary>
        ///     The <see cref="Exception" />, that was thrown during failing test execution.
        /// </summary>
        public Exception ScenarioError => ScenarioContext.TestError;

        /// <summary>
        ///     Method, that marks the StepDefinition method as incomplete by throwing an <see cref="NotImplementedException" />.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
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