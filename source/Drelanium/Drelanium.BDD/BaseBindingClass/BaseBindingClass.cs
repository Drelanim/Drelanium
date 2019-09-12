using System;
using BoDi;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings.Reflection;

namespace Drelanium.BDD
{
    /// <summary>
    ///     BaseClass for StepDefinition and Hooks SpecFlow classes.
    ///     <para>Apply <see cref="BindingAttribute" /> on the inherited classes to make it visible for SpecFlow.</para>
    ///     <para>
    ///         Use <see cref="GivenAttribute" /> | <see cref="WhenAttribute" /> | <see cref="ThenAttribute" /> attributes
    ///         for StepDefinition methods.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeTestRunAttribute" /> | <see cref="AfterTestRunAttribute" /> for TestRun SetUp and
    ///         TearDowns.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeFeatureAttribute" /> | <see cref="AfterFeatureAttribute" /> for Feature SetUp and
    ///         TearDowns.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeScenarioAttribute" /> | <see cref="AfterScenarioAttribute" /> for Scenario SetUp and
    ///         TearDowns.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeScenarioBlockAttribute" /> | <see cref="AfterScenarioBlockAttribute" /> for
    ///         ScenarioBlock SetUp and TearDowns.
    ///     </para>
    ///     <para>Use <see cref="BeforeStepAttribute" /> | <see cref="AfterStepAttribute" /> for Step SetUp and TearDowns.</para>
    /// </summary>
    public abstract class BaseBindingClass : ISpecFlowContextContainer
    {
        /// <summary>
        ///     <inheritdoc cref="BaseBindingClass" />
        /// </summary>
        /// <param name="testThreadContext">Context object, that can be used during the usage of the TestThread.</param>
        /// <param name="featureContext">Context object, that can be used during the execution of the Feature.</param>
        /// <param name="scenarioContext">Context object, that can be used during the execution of the Scenario.</param>
        protected BaseBindingClass(
            [NotNull] TestThreadContext testThreadContext,
            [NotNull] FeatureContext featureContext,
            [NotNull] ScenarioContext scenarioContext)
        {
            TestThreadContext = testThreadContext ?? throw new ArgumentNullException(nameof(testThreadContext));
            FeatureContext = featureContext ?? throw new ArgumentNullException(nameof(featureContext));
            ScenarioContext = scenarioContext ?? throw new ArgumentNullException(nameof(scenarioContext));
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
        ///     The title of the currently executed Feature.
        /// </summary>
        public string FeatureTitle => FeatureInfo.Title;

        /// <summary>
        ///     The title of the currently executed Scenario.
        /// </summary>
        public string ScenarioTitle => ScenarioInfo.Title;

        /// <summary>
        ///     The full name of the currently executed Step.
        /// </summary>
        public string StepName => StepInfo.StepDefinitionType + " " + StepInfo.Text;

        /// <summary>
        ///     The StepDefinition method, that has been bound to the currently executed Step.
        /// </summary>
        public IBindingMethod BindingStepDefinitionMethod => StepInfo.BindingMatch.StepBinding.Method;

        /// <summary>
        ///     The execution status of the currently executed Scenario.
        /// </summary>
        public ScenarioExecutionStatus ScenarioExecutionStatus => ScenarioContext.ScenarioExecutionStatus;

        /// <summary>
        ///     The <see cref="Exception" />, that was thrown during failing test execution.
        /// </summary>
        public Exception ScenarioError => ScenarioContext.TestError;

        /// <summary>
        ///     Gets or sets the currently used <see cref="IWebDriver" />, using a <see cref="SpecFlowContext" />.
        /// </summary>
        public virtual IWebDriver Driver
        {
            get => TestThreadContext.Get<IWebDriver>();
            set => TestThreadContext.Set(value);
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="Serilog.Core.Logger" />, using a <see cref="SpecFlowContext" />.
        /// </summary>
        public virtual Logger Logger
        {
            get => TestThreadContext.Get<Logger>();
            set => TestThreadContext.Set(value);
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="IPageObject" />, using a <see cref="SpecFlowContext" />.
        /// </summary>
        public virtual IPageObject CurrentPage
        {
            get => ScenarioContext.Get<IPageObject>();
            set => ScenarioContext.Set(value);
        }

        /// <summary>
        ///     Context object, that can be used during the usage of the TestThread.
        /// </summary>
        public TestThreadContext TestThreadContext { get; }

        /// <summary>
        ///     Context object, that can be used during the execution of the Feature.
        /// </summary>
        public FeatureContext FeatureContext { get; }

        /// <summary>
        ///     Context object, that can be used during the execution of the Scenario.
        /// </summary>
        public ScenarioContext ScenarioContext { get; }

        /// <summary>
        ///     Context object, that can be used during the execution of the Step.
        /// </summary>
        public ScenarioStepContext StepContext => ScenarioContext.StepContext;

        /// <summary>
        ///     Method, that marks the StepDefinition method as incomplete by throwing a <see cref="NotImplementedException" />.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void NotImplementedStepDefinition()
        {
            throw new NotImplementedException(
                $"StepDefinition implementation in method {BindingStepDefinitionMethod} is incomplete for \n" +
                $"Feature: {FeatureInfo.Title} \n" +
                $"Scenario: {ScenarioInfo.Title} \n" +
                $"Step: {StepName}",
                new PendingStepException());
        }
    }
}