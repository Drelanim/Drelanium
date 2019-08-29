using System;
using System.Collections.ObjectModel;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.Extensions.WebDriverWaitExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.SearchContext
{
    /// <summary>
    ///     Extended implementation of <see cref="ISearchContext" />
    /// </summary>
    public class Search : ISearchContext
    {
        /// <summary>
        ///     <see cref="Search" />
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        public Search(ISearchContext searchContext)
        {
            SearchContextImplementation = searchContext;
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="ISearchContext" />
        private ISearchContext SearchContextImplementation { get; }


        /// <summary>
        ///     <inheritdoc>To be added...</inheritdoc>
        /// </summary>
        public IWebElement FindElement(By by)
        {
            return SearchContextImplementation.FindElement(by);
        }

        /// <summary>
        ///     <inheritdoc>To be added...</inheritdoc>
        /// </summary>
        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return SearchContextImplementation.FindElements(by);
        }

        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <inheritdoc cref="FindElements(By)" />
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindDisplayedElement(By locator, TimeSpan timeout, Logger logger = null)
        {
            SearchContextImplementation
                .Wait(timeout,
                    ignoredExceptionTypes: new[]
                        {typeof(NoSuchElementException), typeof(StaleElementReferenceException)})
                .UntilElementIsDisplayed(SearchContextImplementation, locator);

            return FindElement(locator);
        }

        /// <summary>
        ///     To Be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="by">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindElement(By by, Logger logger)
        {
            logger?.Information($"Attempting to Find element By ({by}).");

            var result = FindElement(by);

            logger?.Information($"Element ({by}) has been found.");

            return result;
        }

        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <inheritdoc cref="FindElement(By)" />
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element By ({locator}).");

            var result = SearchContextImplementation
                .Wait(timeout, ignoredExceptionTypes: new[] {typeof(NoSuchElementException)})
                .UntilElementExists(SearchContextImplementation, locator, logger);

            logger?.Information($"Element ({locator}) has been found.");

            return result;
        }

        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <inheritdoc cref="FindElements(By)" />
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="condition">
        ///     The <see cref="Func{IWebDriver, IWebElement}" />, that defines the condition until the browser
        ///     must wait.
        /// </param>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Func<IWebDriver, IWebElement> condition,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element By ({locator}).");

            var result = SearchContextImplementation
                .Wait(timeout, timeoutMessage, ignoredExceptionTypes)
                .Until(condition);

            logger?.Information($"Element ({locator}) has been found.");

            return result;
        }

        /// <summary>
        ///     To be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <inheritdoc cref="FindElements(By)" />
        /// <param name="by">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public ReadOnlyCollection<IWebElement> FindElements(By by, Logger logger)
        {
            logger?.Information($"Attempting to Find element By ({by}).");

            var result = FindElements(by);

            logger?.Information($"Found ({result.Count}) number of elements.");

            return result;
        }


        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="locator">The locating mechanism to use.</param>
        public bool HasElement(By locator)
        {
            return FindElements(locator).Count > 0;
        }
    }
}