using System;
using System.Diagnostics;
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
    ///         Use <see cref="GivenAttribute" /> | <see cref="WhenAttribute" /> | <see cref="ThenAttribute" /> method
    ///         attributes
    ///         for StepDefinition non-static methods.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeTestRunAttribute" /> | <see cref="AfterTestRunAttribute" /> method attributes to implement
    ///         TestRun SetUp
    ///         and TearDown static methods.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeFeatureAttribute" /> | <see cref="AfterFeatureAttribute" /> method attributes to implement
    ///         Feature SetUp
    ///         and TearDown static methods.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeScenarioAttribute" /> | <see cref="AfterScenarioAttribute" /> method attributes to
    ///         implement Scenario
    ///         SetUp and TearDown non-static methods.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeScenarioBlockAttribute" /> | <see cref="AfterScenarioBlockAttribute" /> method attributes
    ///         to implement
    ///         ScenarioBlock SetUp and TearDown non-static methods.
    ///     </para>
    ///     <para>
    ///         Use <see cref="BeforeStepAttribute" /> | <see cref="AfterStepAttribute" /> method attributes to implement Step
    ///         SetUp and
    ///         TearDown non-static methods.
    ///     </para>
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
        ///     Gets the <see cref="IObjectContainer" /> object, that can be used during the usage of the TestThread.
        /// </summary>
        public IObjectContainer TestThreadContainer => TestThreadContext.TestThreadContainer;

        /// <summary>
        ///     Gets the <see cref="IObjectContainer" /> object, that can be used during the usage of the Feature.
        /// </summary>
        public IObjectContainer FeatureContainer => FeatureContext.FeatureContainer;

        /// <summary>
        ///     Gets the <see cref="IObjectContainer" /> object, that can be used during the usage of the Scenario.
        /// </summary>
        public IObjectContainer ScenarioContainer => ScenarioContext.ScenarioContainer;

        /// <summary>
        ///     Gets the <see cref="TechTalk.SpecFlow.FeatureInfo" /> object, that can be used to retrieve info about the currently
        ///     executed
        ///     Feature.
        /// </summary>
        public FeatureInfo FeatureInfo => FeatureContext.FeatureInfo;

        /// <summary>
        ///     Gets the <see cref="TechTalk.SpecFlow.ScenarioInfo" /> object, that can be used to retrieve info about the
        ///     currently
        ///     executed Scenario.
        /// </summary>
        public ScenarioInfo ScenarioInfo => ScenarioContext.ScenarioInfo;

        /// <summary>
        ///     Gets the <see cref="TechTalk.SpecFlow.StepInfo" /> object, that can be used to retrieve info about the currently
        ///     executed
        ///     Step.
        /// </summary>
        public StepInfo StepInfo => StepContext.StepInfo;

        /// <summary>
        ///     Gets the title of the currently executed Feature.
        /// </summary>
        public string FeatureTitle => FeatureInfo.Title;

        /// <summary>
        ///     Gets the title of the currently executed Scenario.
        /// </summary>
        public string ScenarioTitle => ScenarioInfo.Title;

        /// <summary>
        ///     Gets the full name of the currently executed Step.
        /// </summary>
        public string StepName => StepInfo.StepDefinitionType + " " + StepInfo.Text;

        /// <summary>
        ///     Gets the StepDefinition method, that has been bound to the currently executed Step.
        /// </summary>
        public IBindingMethod BindingStepDefinitionMethod => StepInfo.BindingMatch.StepBinding.Method;

        /// <summary>
        ///     Gets the execution status of the currently executed Scenario.
        /// </summary>
        public ScenarioExecutionStatus ScenarioExecutionStatus => ScenarioContext.ScenarioExecutionStatus;

        /// <summary>
        ///     Gets the <see cref="Exception" />, that was thrown during failing test execution.
        /// </summary>
        public Exception ScenarioError => ScenarioContext.TestError;

        /// <summary>
        ///     Gets or sets the currently used <see cref="IWebDriver" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.SpecFlowContext" /> object, by it's <see cref="TechTalk.SpecFlow.SpecFlowContext" />
        ///     .Get() or <see cref="TechTalk.SpecFlow.SpecFlowContext" />.Set() methods.
        ///     <para>Default virtual getter and setter implementation:</para>
        ///     <para>get => TestThreadContext.Get&lt;<see cref="IWebDriver" />&gt;( nameof(Driver) );</para>
        ///     <para>set => TestThreadContext.Set(value, nameof(Driver) );</para>
        /// </summary>
        public virtual IWebDriver Driver
        {
            get => TestThreadContext.ContainsKey(nameof(Driver))
                ? TestThreadContext.Get<IWebDriver>(nameof(Driver))
                : null;
            set => TestThreadContext.Set(value, nameof(Driver));
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="Serilog.Core.Logger" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.SpecFlowContext" /> object, by it's <see cref="TechTalk.SpecFlow.SpecFlowContext" />
        ///     .Get() or <see cref="TechTalk.SpecFlow.SpecFlowContext" />.Set() methods.
        ///     <para>Default virtual getter and setter implementation:</para>
        ///     <para>get => TestThreadContext.Get&lt;<see cref="Serilog.Core.Logger" />&gt;( nameof(Logger) );</para>
        ///     <para>set => TestThreadContext.Set(value, nameof(Logger) );</para>
        /// </summary>
        public virtual Logger Logger
        {
            get => TestThreadContext.ContainsKey(nameof(Logger)) ? TestThreadContext.Get<Logger>(nameof(Logger)) : null;
            set => TestThreadContext.Set(value, nameof(Logger));
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="IPageObject" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.SpecFlowContext" /> object, by it's <see cref="TechTalk.SpecFlow.SpecFlowContext" />
        ///     .Get() or <see cref="TechTalk.SpecFlow.SpecFlowContext" />.Set() methods.
        ///     <para>Default virtual getter and setter implementation:</para>
        ///     <para>get => ScenarioContext.Get&lt;<see cref="IPageObject" />&gt;( nameof(CurrentPageObject) );</para>
        ///     <para>set => ScenarioContext.Set(value, nameof(CurrentPageObject) );</para>
        /// </summary>
        public virtual IPageObject CurrentPageObject
        {
            get => ScenarioContext.ContainsKey(nameof(CurrentPageObject))
                ? ScenarioContext.Get<IPageObject>(nameof(CurrentPageObject))
                : null;
            set => ScenarioContext.Set(value, nameof(CurrentPageObject));
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="System.Diagnostics.Stopwatch" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.TestThreadContext" /> object, by it's
        ///     <see cref="TechTalk.SpecFlow.TestThreadContext" />.Get() or <see cref="TechTalk.SpecFlow.TestThreadContext" />
        ///     .Set() methods.
        ///     <para>
        ///         Should be Initialized, Started and Stopped by Hook methods with <see cref="BeforeFeatureAttribute" /> and
        ///         <see cref="AfterFeatureAttribute" /> attributes, with the following methods:
        ///     </para>
        ///     <para>get => TestThreadContext.Get&lt;<see cref="Stopwatch" />&gt;( nameof(TestThreadStopWatch) );</para>
        ///     <para>set => TestThreadContext.Set(value, nameof(TestThreadStopWatch) );</para>
        /// </summary>
        public Stopwatch TestThreadStopWatch
        {
            get => TestThreadContext.ContainsKey(nameof(TestThreadStopWatch))
                ? TestThreadContext.Get<Stopwatch>(nameof(TestThreadStopWatch))
                : null;
            set => TestThreadContext.Set(value, nameof(TestThreadStopWatch));
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="System.Diagnostics.Stopwatch" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.FeatureContext" />object, by it's <see cref="TechTalk.SpecFlow.FeatureContext" />
        ///     .Get() or <see cref="TechTalk.SpecFlow.FeatureContext" />.Set() methods.
        ///     <para>
        ///         Should be Initialized, Started and Stopped by Hook methods with <see cref="BeforeFeatureAttribute" /> and
        ///         <see cref="AfterFeatureAttribute" /> attributes, with the following methods:
        ///     </para>
        ///     <para>get => FeatureContext.Get&lt;<see cref="Stopwatch" />&gt;( nameof(FeatureStopwatch) );</para>
        ///     <para>set => FeatureContext.Set(value, nameof(FeatureStopwatch) );</para>
        /// </summary>
        public Stopwatch FeatureStopwatch
        {
            get => FeatureContext.ContainsKey(nameof(FeatureStopwatch))
                ? FeatureContext.Get<Stopwatch>(nameof(FeatureStopwatch))
                : null;
            set => FeatureContext.Set(value, nameof(FeatureStopwatch));
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="System.Diagnostics.Stopwatch" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.ScenarioContext" />object, by it's <see cref="TechTalk.SpecFlow.ScenarioContext" />
        ///     .Get() or <see cref="TechTalk.SpecFlow.ScenarioContext" />.Set() methods.
        ///     <para>
        ///         Should be Initialized, Started and Stopped by Hook methods with <see cref="BeforeScenarioAttribute" /> and
        ///         <see cref="AfterScenarioAttribute" /> attributes, with the following methods:
        ///     </para>
        ///     <para>get => ScenarioContext.Get&lt;<see cref="Stopwatch" />&gt;( nameof(ScenarioStopwatch) );</para>
        ///     <para>set => ScenarioContext.Set(value, nameof(ScenarioStopwatch) );</para>
        /// </summary>
        public Stopwatch ScenarioStopwatch
        {
            get => ScenarioContext.ContainsKey(nameof(ScenarioStopwatch))
                ? ScenarioContext.Get<Stopwatch>(nameof(ScenarioStopwatch))
                : null;
            set => ScenarioContext.Set(value, nameof(ScenarioStopwatch));
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="System.Diagnostics.Stopwatch" /> from a thread-safe
        ///     <see cref="TechTalk.SpecFlow.ScenarioStepContext" />object, by it's
        ///     <see cref="TechTalk.SpecFlow.ScenarioStepContext" />.Get() or <see cref="TechTalk.SpecFlow.ScenarioStepContext" />
        ///     .Set() methods.
        ///     <para>
        ///         Should be Initialized, Started and Stopped by Hook methods with <see cref="BeforeStepAttribute" /> and
        ///         <see cref="AfterStepAttribute" /> attributes, with the following methods:
        ///     </para>
        ///     <para>get => StepContext.Get&lt;<see cref="Stopwatch" />&gt;( nameof(StepStopWatch) );</para>
        ///     <para>set => StepContext.Set(value, nameof(StepStopWatch) );</para>
        /// </summary>
        public Stopwatch StepStopWatch
        {
            get => StepContext.ContainsKey(nameof(StepStopWatch))
                ? StepContext.Get<Stopwatch>(nameof(StepStopWatch))
                : null;
            set => StepContext.Set(value, nameof(StepStopWatch));
        }

        /// <summary>
        ///     Gets the thread-safe context object, that can be used during the usage of the TestThread.
        /// </summary>
        public TestThreadContext TestThreadContext { get; }

        /// <summary>
        ///     Gets the thread-safe context object, that can be used during the execution of the Feature.
        /// </summary>
        public FeatureContext FeatureContext { get; }

        /// <summary>
        ///     Gets the thread-safe context object, that can be used during the execution of the Scenario.
        /// </summary>
        public ScenarioContext ScenarioContext { get; }

        /// <summary>
        ///     Gets the thread-safe context object, that can be used during the execution of the Step.
        /// </summary>
        public ScenarioStepContext StepContext => ScenarioContext.StepContext;

        /// <summary>
        ///     Method, that marks the StepDefinition method as incomplete by throwing a <see cref="NotImplementedException" />.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void NotImplementedStepDefinition()
        {
            throw new NotImplementedException(
                $"StepDefinition implementation in Method: {BindingStepDefinitionMethod} is incomplete for Step: {StepName}",
                new PendingStepException());
        }
    }
}