using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable CommentTypo

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class SubmitMethods
    {
        /// <summary>
        ///     <inheritdoc cref="IWebElement.Submit()" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void Submit(
            this IWebElement element,
            Logger logger)
        {
            logger?.Information($"Attempting to Submit on element ({element}).");

            element.Submit();

            logger?.Information("Submit on element was successful.");
        }

        /// <summary>
        ///     <inheritdoc cref="IWebElement.Submit()" />
        ///     <para>Method is repeated until the element is successfully submitted to the web server.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        public static void Submit(
            this IWebElement element,
            double timeoutInSeconds,
            Logger logger = null)
        {
            logger?.Information($"Attempting to Submit on element ({element}).");

            element
                .Wait(timeoutInSeconds,
                    $"Waited ({timeoutInSeconds}) seconds until ({element}) element is successfully submitted to the web server.",
                    new[] {typeof(WebDriverException)})
                .Until(webDriver =>
                {
                    element.Submit();
                    return true;
                });

            logger?.Information("Submit on element was successful.");
        }

        /// <summary>
        ///     Submits this <see cref="IWebElement" />, then waits until the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
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
        /// <param name="timeoutInSeconds"></param>
        public static void Submit<TResult>(
            this IWebElement element,
            double timeoutInSeconds,
            Func<IWebDriver, TResult> condition,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null, double sleepIntervalInSeconds = 0.5,
            IClock clock = null,
            Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            var timeBeforeClick = DateTime.Now;

            element.Submit(timeoutInSeconds, logger);

            var remainingTimeOut = timeoutInSeconds - (DateTime.Now - timeBeforeClick).TotalSeconds;

            if (!string.IsNullOrEmpty(timeoutMessage))
            {
                timeoutMessage =
                    $"Waited (remaining time: {remainingTimeOut}) seconds for after-submit condition to meet!";
            }

            element
                .Wait(remainingTimeOut, timeoutMessage, ignoredExceptionTypes, sleepIntervalInSeconds, clock)
                .Until(condition);
        }
    }
}