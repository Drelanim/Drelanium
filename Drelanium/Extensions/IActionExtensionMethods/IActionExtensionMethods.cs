using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.Extensions.IActionExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IAction" /> types.
    /// </summary>
    public static class IActionExtensionMethods
    {
        /// <summary>
        ///     Performs this action on the browser, and then waits until the condition is met.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="action">The <see cref="IAction" /> chain, that should be performed on the browser.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{IWebDriver,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void PerformWithCondition<TResult>(this IAction action, WebDriverWait wait,
            Func<IWebDriver, TResult> condition, Logger logger = null)
        {
            logger?.Information(
                $"Performing chained actions and waiting for condition until {wait.Timeout.TotalSeconds}.");

            action.Perform();
            wait.Until(condition);
        }
    }
}