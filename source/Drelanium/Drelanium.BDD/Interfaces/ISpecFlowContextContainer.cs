using TechTalk.SpecFlow;

namespace Drelanium.BDD
{
    /// <summary>
    ///     Interface, that demands to implement <see cref="SpecFlowContext" /> properties.
    /// </summary>
    public interface ISpecFlowContextContainer
    {
        /// <summary>
        ///     Context object, that can be used during the usage of the TestThread.
        /// </summary>
        TestThreadContext TestThreadContext { get; }

        /// <summary>
        ///     Context object, that can be used during the execution of the Feature.
        /// </summary>
        FeatureContext FeatureContext { get; }

        /// <summary>
        ///     Context object, that can be used during the execution of the Scenario.
        /// </summary>
        ScenarioContext ScenarioContext { get; }

        /// <summary>
        ///     Context object, that can be used during the execution of the Step.
        /// </summary>
        ScenarioStepContext StepContext { get; }
    }
}