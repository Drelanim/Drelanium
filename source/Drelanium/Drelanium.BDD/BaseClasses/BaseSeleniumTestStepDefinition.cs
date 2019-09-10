using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using TechTalk.SpecFlow;

namespace Drelanium.BDD
{
    /// <summary>
    ///     Base for classes, that has <see cref="BindingAttribute" /> on it, and holds methods with
    ///     <see cref="GivenAttribute" /> | <see cref="WhenAttribute" /> | <see cref="ThenAttribute" /> attributes.
    ///     <para>Also contains properties, to support Selenium tests.</para>
    /// </summary>
    public abstract class BaseSeleniumTestStepDefinition : BaseStepDefinition
    {
        /// <summary>
        ///     <inheritdoc cref="BaseSeleniumTestStepDefinition" />
        /// </summary>
        /// <param name="testThreadContext">Context object, that can be used during the usage of the TestThread.</param>
        /// <param name="featureContext">Context object, that can be used during the execution of the Feature.</param>
        /// <param name="scenarioContext">Context object, that can be used during the execution of the Scenario.</param>
        protected BaseSeleniumTestStepDefinition(
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
        ///     Gets or sets the currently used <see cref="IWebDriver" />, using a <see cref="SpecFlowContext" />.
        /// </summary>
        public virtual IWebDriver Driver
        {
            get => TestThreadContext.GetDriver();
            set => TestThreadContext.SetDriver(value);
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="Serilog.Core.Logger" />, using a <see cref="SpecFlowContext" />.
        /// </summary>
        public virtual Logger Logger
        {
            get => TestThreadContext.GetLogger();
            set => TestThreadContext.SetLogger(value);
        }

        /// <summary>
        ///     Gets or sets the currently used <see cref="IPageObject" />, using a <see cref="SpecFlowContext" />.
        /// </summary>
        public virtual IPageObject CurrentPage
        {
            get => ScenarioContext.GetCurrentPageObject();
            set => ScenarioContext.SetCurrentPageObject(value);
        }
    }
}