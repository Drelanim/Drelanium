using System;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    ///     ...Description to be added...
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
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public static void Click(this IWebElement element, TimeSpan timeout, Logger logger = null)
        {
            logger?.Information($"Attempting to Click on element ({element}).");

            element
                .Wait(timeout,
                    $"Waited ({timeout.TotalSeconds}) seconds until ({element}) element is successfully clicked",
                    new[] {typeof(WebDriverException)})
                .Until(webDriver =>
                {
                    element.Click();
                    return true;
                });

            logger?.Information("Click on element was successful.");
        }


        /// <summary>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">...Description to be added...</param>
        /// <param name="timeoutForClick">...Description to be added...</param>
        /// <param name="timeoutForAfterClickCondition">...Description to be added...</param>
        /// <param name="afterClickCondition">...Description to be added...</param>
        /// <param name="ignoredExceptionTypes">...Description to be added...</param>
        /// <param name="logger">...Description to be added...</param>
        /// <typeparam name="TResult">...Description to be added...</typeparam>
        public static void Click<TResult>(this IWebElement element, TimeSpan timeoutForClick,
            TimeSpan timeoutForAfterClickCondition, Func<IWebDriver, TResult> afterClickCondition,
            Type[] ignoredExceptionTypes = null, Logger logger = null)
        {
            element.Click(timeoutForClick, logger);

            logger?.Information("Waiting for after-click condition to meet.");

            element.Wait(
                    timeoutForAfterClickCondition,
                    $"Waited ({timeoutForAfterClickCondition.TotalSeconds}) seconds for after-click condition to meet!",
                    ignoredExceptionTypes)
                .Until(afterClickCondition);

            logger?.Information("After-click condition is met.");
        }
    }
}