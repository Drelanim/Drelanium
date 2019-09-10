using System;
using JetBrains.Annotations;
using TechTalk.SpecFlow;

namespace Drelanium.BDD
{
    /// <summary>
    ///     Base for classes, that has <see cref="BindingAttribute" /> on it.
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
    }
}