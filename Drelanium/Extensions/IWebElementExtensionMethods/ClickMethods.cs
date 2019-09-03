using System;
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
        public static void Click(this IWebElement element, Logger logger)
        {
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
        public static void Click(this IWebElement element, double timeoutInSeconds, Logger logger = null)
        {
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
        ///     <inheritdoc cref="IWebElement.Click()" />
        ///     <para>Method is repeated until the element is successfully clicked.</para>
        ///     <para>After the successful click, the browser waits until the given after-click condition is met.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="timeoutInSecondsForClick">The timeout value indicating how long to wait for the successful click.</param>
        /// <param name="timeoutInSecondsForAfterClickCondition">
        ///     The timeout value indicating how long to wait for the after-click
        ///     condition.
        /// </param>
        /// <param name="afterClickCondition">
        ///     The <see cref="Func{IWebDriver, TResult}" />, that defines the condition until the browser
        ///     must wait after the click has been successfully executed.
        /// </param>
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
        /// <typeparam name="TResult">...Description to be added...</typeparam>
        public static void Click<TResult>(this IWebElement element,
            double timeoutInSecondsForClick,
            double timeoutInSecondsForAfterClickCondition, Func<IWebDriver, TResult> afterClickCondition,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null, double sleepIntervalInSeconds = 0.5,
            IClock clock = null,
            Logger logger = null)
        {
            element.Click(timeoutInSecondsForClick, logger);

            element
                .Wait(timeoutInSecondsForAfterClickCondition,
                    $"Waited ({timeoutInSecondsForAfterClickCondition}) seconds for after-click condition to meet!",
                    ignoredExceptionTypes, sleepIntervalInSeconds, clock)
                .Until(afterClickCondition);
        }
    }
}