using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="ISearchContext" /> types.
    /// </summary>
    public static class FindClickableElementMethods
    {
        /// <summary>
        ///     Finds the first <see cref="IWebElement" /> using the given method, then waits until the element becomes Clickable.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="sleepIntervalInSeconds">
        ///     A <see cref="TimeSpan" /> value indicating how often to check for the condition to
        ///     be true.
        /// </param>
        /// <param name="clock">An object implementing the <see cref="IClock" /> interface used to determine when time has passed.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during the method exeuction.
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static IWebElement FindClickableElement(
            this ISearchContext searchContext,
            By locator,
            double timeoutInSeconds, string timeoutMessage = "",
            Type[] ignoredExceptionTypes = null, double sleepIntervalInSeconds = 0.5, IClock clock = null,
            Logger logger = null)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            logger?.Information($"Attempting to Find Clickable element with ({locator}).");

            var timeBeforeElement = DateTime.Now;

            var element = searchContext.FindElement(locator, timeoutInSeconds);

            var remainingTimeOut = timeoutInSeconds - (DateTime.Now - timeBeforeElement).TotalSeconds;

            searchContext
                .Wait(remainingTimeOut, timeoutMessage, ignoredExceptionTypes, sleepIntervalInSeconds, clock)
                .UntilElementIsClickable(searchContext, locator);

            logger?.Information($"Clickable element ({locator}) has been found.");

            return element;
        }
    }
}