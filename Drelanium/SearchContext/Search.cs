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
        ///     <inheritdoc cref="Search" />
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        public Search(ISearchContext searchContext)
        {
            SearchContextImplementation = searchContext;
        }

        /// <summary>
        ///     <inheritdoc cref="ISearchContext" />
        /// </summary>
        private ISearchContext SearchContextImplementation { get; }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </summary>
        public IWebElement FindElement(By locator)
        {
            return SearchContextImplementation.FindElement(locator);
        }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElements(By)" />
        /// </summary>
        public ReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return SearchContextImplementation.FindElements(locator);
        }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        ///     <para>Waits until the element gets displayed.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
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
                .UntilElementIsDisplayed(SearchContextImplementation, locator, logger);

            return FindElement(locator);
        }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindElement(By locator, Logger logger)
        {
            logger?.Information($"Attempting to Find element with ({locator}).");

            var result = FindElement(locator);

            logger?.Information($"Element ({locator}) has been found.");

            return result;
        }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        ///     <para>Method is repeated until the element is successfully found within the timeout.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element with ({locator}).");

            var result = SearchContextImplementation
                .Wait(timeout, ignoredExceptionTypes: new[] {typeof(NoSuchElementException)})
                .UntilElementExists(SearchContextImplementation, locator, logger);

            logger?.Information($"Element ({locator}) has been found.");

            return result;
        }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        ///     <para>Method is repeated until the element is successfully found and the condition is met.</para>
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="condition">
        ///     The <see cref="Func{IWebDriver, IWebElement}" />, that defines the condition until the browser
        ///     must wait.
        /// </param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Func<IWebDriver, IWebElement> condition,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null, Logger logger = null)
        {
            var result = FindElement(locator, timeout, logger);

            SearchContextImplementation
                .Wait(timeout, timeoutMessage, ignoredExceptionTypes)
                .Until(condition, logger);

            return result;
        }


        /// <summary>
        ///     <inheritdoc cref="ISearchContext.FindElements(By)" />
        ///     <para>Logs the event.</para>
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public ReadOnlyCollection<IWebElement> FindElements(By locator, Logger logger)
        {
            logger?.Information($"Attempting to Find element with ({locator}).");

            var result = FindElements(locator);

            logger?.Information($"Found ({result.Count}) number of elements with ({locator}).");

            return result;
        }


        /// <summary>
        ///     Checks if the element can or cannot be found within the SearchContext.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public bool HasElement(By locator)
        {
            return FindElements(locator).Count > 0;
        }
    }
}