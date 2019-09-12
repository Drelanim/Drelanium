using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IAction" /> types.
    /// </summary>
    public static class IActionExtensionMethods
    {
        /// <summary>
        ///     <inheritdoc cref="IAction.Perform()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="action"></param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during the method exeuction.
        /// </param>
        public static void Perform([NotNull] this IAction action, [CanBeNull] Logger logger)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));

            logger?.Information("Attempting to perform chained actions");

            action.Perform();

            logger?.Information("Performing chained actions has been finished successfully!");
        }

        /// <summary>
        ///     <inheritdoc cref="IAction.Perform()" />
        ///     <para>After perform, the browser waits until the given condition is met.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="action">The <see cref="IAction" /> chain, that should be performed on the browser.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void Perform<TResult>([NotNull] this IAction action, [NotNull] WebDriverWait wait,
            [NotNull] Func<IWebDriver, TResult> condition, [CanBeNull] Logger logger = null)
        {
            if (action == null) throw new ArgumentNullException(nameof(action));
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            action.Perform(logger);

            wait.Until(condition);
        }
    }
}