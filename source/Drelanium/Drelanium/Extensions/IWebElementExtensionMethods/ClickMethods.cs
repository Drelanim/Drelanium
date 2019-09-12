using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class ClickMethods
    {
        /// <summary>
        ///     <inheritdoc cref="IWebElement.Click()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void Click(
            [NotNull] this IWebElement element,
            [CanBeNull] Logger logger)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            logger?.Information($"Attempting to Click on element ({element}).");

            element.Click();

            logger?.Information("Click on element was successful.");
        }

        /// <summary>
        ///     <inheritdoc cref="IWebElement.Click()" />
        ///     <para>Method is repeated until the element is successfully clicked.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        public static void Click(
            [NotNull] this IWebElement element,
            double timeoutInSeconds,
            [CanBeNull] Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            logger?.Information($"Attempting to Click on element ({element}).");

            element
                .Wait(timeoutInSeconds,
                    $"Waited ({timeoutInSeconds}) seconds until ({element}) element is successfully clicked.",
                    new[] {typeof(WebDriverException)})
                .Until(webDriver =>
                {
                    element.Click();
                    return true;
                });

            logger?.Information("Click on element was successful.");
        }

        /// <summary>
        ///     Clicks this <see cref="IWebElement" />, then waits until the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="clock">An object implementing the <see cref="IClock" /> interface used to determine when time has passed.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="sleepIntervalInSeconds">
        ///     A <see cref="TimeSpan" /> value indicating how often to check for the condition to
        ///     be true.
        /// </param>
        public static void Click<TResult>(
            [NotNull] this IWebElement element,
            double timeoutInSeconds,
            [NotNull] Func<IWebDriver, TResult> condition,
            [CanBeNull] string timeoutMessage = "", [CanBeNull] Type[] ignoredExceptionTypes = null,
            double sleepIntervalInSeconds = 0.5,
            [CanBeNull] IClock clock = null,
            [CanBeNull] Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            var timeBeforeClick = DateTime.Now;

            element.Click(timeoutInSeconds, logger);

            var remainingTimeOut = timeoutInSeconds - (DateTime.Now - timeBeforeClick).TotalSeconds;

            if (!string.IsNullOrEmpty(timeoutMessage))
            {
                timeoutMessage =
                    $"Waited (remaining time: {remainingTimeOut}) seconds for after-click condition to meet!";
            }

            element
                .Wait(remainingTimeOut, timeoutMessage, ignoredExceptionTypes, sleepIntervalInSeconds, clock)
                .Until(condition);
        }
    }
}