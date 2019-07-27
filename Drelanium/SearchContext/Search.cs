using System;
using System.Collections.ObjectModel;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.Extensions.WebDriverWaitExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.SearchContext
{

    public class Search : ISearchContext
    {

        /// <param name="searchContext">The context used to search element.</param>
        public Search(ISearchContext searchContext)
        {
            SearchContextImplementation = searchContext;
        }

        private ISearchContext SearchContextImplementation { get; }

        public IWebElement FindElement(By by)
        {
            return SearchContextImplementation.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return SearchContextImplementation.FindElements(by);
        }

        /// <param name="locator">The locating mechanism to use.</param>
        public bool HasElement(By locator)
        {
            return FindElements(locator).Count > 0;
        }

        /// <summary>
        ///     Finds the first <see cref="IWebElement" />, until a set timeout.
        /// </summary>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public IWebElement FindElement(By locator, TimeSpan timeout)
        {
            return SearchContextImplementation
                .Wait(timeout, ignoredExceptionTypes: new[] {typeof(NoSuchElementException)})
                .UntilElementExists(SearchContextImplementation, locator);
        }

        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="condition">The condition, that the driver is waiting for.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public IWebElement FindElement(By locator, TimeSpan timeout, Func<IWebDriver, IWebElement> condition, string timeoutMessage = "", Type[] ignoredExceptionTypes = null)
        {
            return SearchContextImplementation
                .Wait(timeout, timeoutMessage, ignoredExceptionTypes)
                .Until(condition);
        }

        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public IWebElement FindDisplayedElement(By locator, TimeSpan timeout)
        {



            SearchContextImplementation
                .Wait(timeout, ignoredExceptionTypes: new[] {typeof(NoSuchElementException), typeof(StaleElementReferenceException)})
                .UntilElementIsDisplayed(SearchContextImplementation, locator);

            return FindElement(locator);




        }

    }

}