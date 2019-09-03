using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable CommentTypo

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="ISearchContext" /> types.
    /// </summary>
    public static class FindElementMethods
    {
        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        public static IWebElement FindElement(
            [NotNull] this ISearchContext searchContext,
            [NotNull] By locator,
            [CanBeNull] Logger logger)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            logger?.Information($"Attempting to Find element with ({locator}).");

            var element = searchContext.FindElement(locator);

            logger?.Information($"Element ({locator}) has been found.");

            return element;
        }

        /// <summary>
        ///     Finds the first <see cref="IWebElement" /> using the given method, then waits until the element meets the given
        ///     condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="clock">An object implementing the <see cref="IClock" /> interface used to determine when time has passed.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="sleepIntervalInSeconds">
        ///     A <see cref="TimeSpan" /> value indicating how often to check for the condition to
        ///     be true.
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static IWebElement FindElement<TResult>(
            [NotNull] this ISearchContext searchContext,
            [NotNull] By locator,
            double timeoutInSeconds,
            [NotNull] Func<IWebElement, TResult> condition,
            [CanBeNull] string timeoutMessage = "", [CanBeNull] Type[] ignoredExceptionTypes = null,
            double sleepIntervalInSeconds = 0.5,
            [CanBeNull] IClock clock = null,
            [CanBeNull] Logger logger = null)

        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            logger?.Information($"Attempting to Find element with ({locator}).");

            var timeBeforeElement = DateTime.Now;

            var element = searchContext.FindElement(locator, timeoutInSeconds);

            var remainingTimeOut = timeoutInSeconds - (DateTime.Now - timeBeforeElement).TotalSeconds;

            searchContext
                .Wait(remainingTimeOut, timeoutMessage, ignoredExceptionTypes, sleepIntervalInSeconds, clock)
                .UntilElement(searchContext, locator, condition);

            logger?.Information($"Element ({locator}) has been found.");

            return element;
        }

        /// <summary>
        ///     Finds the first <see cref="IWebElement" /> using the given method, within the given timeout.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the given condition.</param>
        /// <param>
        ///     <name>clock</name>
        /// </param>
        /// <param name="clock">An object implementing the <see cref="IClock" /> interface used to determine when time has passed.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="sleepIntervalInSeconds">
        ///     A <see cref="TimeSpan" /> value indicating how often to check for the condition to
        ///     be true.
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static IWebElement FindElement(
            [NotNull] this ISearchContext searchContext,
            [NotNull] By locator,
            double timeoutInSeconds,
            [CanBeNull] string timeoutMessage = "", [CanBeNull] Type[] ignoredExceptionTypes = null,
            double sleepIntervalInSeconds = 0.5,
            [CanBeNull] IClock clock = null,
            [CanBeNull] Logger logger = null)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            logger?.Information($"Attempting to Find element with ({locator}).");

            var element = searchContext
                .Wait(timeoutInSeconds, timeoutMessage, ignoredExceptionTypes, sleepIntervalInSeconds, clock)
                .UntilElementExists(searchContext, locator);

            logger?.Information($"Element ({locator}) has been found.");

            return element;
        }
    }
}