using System;
using System.Collections.ObjectModel;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.Extensions.WebDriverWaitExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.SearchContext
{
    /// <summary>
 ///To be added...
 ///</summary>
    public class Search : ISearchContext
    {
        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        public Search(ISearchContext searchContext)
        {
            SearchContextImplementation = searchContext;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        private ISearchContext SearchContextImplementation { get; }

        /// <summary>
 ///To be added...
 ///</summary>
        public IWebElement FindElement(By by)
        {
            return SearchContextImplementation.FindElement(by);
        }

        /// <summary>
 ///To be added...
 ///</summary
 ///>
        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return SearchContextImplementation.FindElements(by);
        }

        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="by">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebElement FindElement(By by, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element By ({by})");

            var result = FindElement(by);

            logger?.Information($"Element ({by}) has been found");

            return result;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="by">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public ReadOnlyCollection<IWebElement> FindElements(By by, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element By ({by})");

            var result = FindElements(by);

            logger?.Information($"Found ({result.Count}) number of elements");

            return result;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="locator">The locating mechanism to use.</param>
        public bool HasElement(By locator)
        {
            return FindElements(locator).Count > 0;
        }

        /// <summary>
 ///Finds the first <see cref="IWebElement" />, until a set timeout.
 ///</summary>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element By ({locator})");

            var result = SearchContextImplementation
                .Wait(timeout, ignoredExceptionTypes: new[] {typeof(NoSuchElementException)})
                .UntilElementExists(SearchContextImplementation, locator, logger);

            logger?.Information($"Element ({locator}) has been found");

            return result;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="condition">The <see cref="Func" />, that defines the condition until the browser must wait.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Func<IWebDriver, IWebElement> condition,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null, Logger logger = null)
        {
            logger?.Information($"Attempting to Find element By ({locator})");

            var result = SearchContextImplementation
                .Wait(timeout, timeoutMessage, ignoredExceptionTypes)
                .Until(condition);

            logger?.Information($"Element ({locator}) has been found");

            return result;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public IWebElement FindDisplayedElement(By locator, TimeSpan timeout, Logger logger = null)
        {
            SearchContextImplementation
                .Wait(timeout,
                    ignoredExceptionTypes: new[]
                        {typeof(NoSuchElementException), typeof(StaleElementReferenceException)})
                .UntilElementIsDisplayed(SearchContextImplementation, locator);

            return FindElement(locator);
        }
    }
}