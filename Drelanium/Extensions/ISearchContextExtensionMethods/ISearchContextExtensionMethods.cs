using System;
using System.ComponentModel;
using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.SearchContext;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium.Extensions.ISearchContextExtensionMethods
{
    /// <summary>To be added...</summary>
    public static class ISearchContextExtensionMethods
    {
        /// <summary>To be added...</summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        private static IWebDriver GetDriver(ISearchContext searchContext)
        {
            switch (searchContext)
            {
                case IWebDriver driver:
                    return driver;

                case IWebElement element:
                    return element.Driver();

                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        /// <summary>To be added...</summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        public static Search Search(this ISearchContext searchContext)
        {
            return new Search(searchContext);
        }

        /// <summary>To be added...</summary>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public static WebDriverWait Wait(this ISearchContext searchContext, TimeSpan timeout,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null)
        {
            var driver = GetDriver(searchContext);

            var wait = new WebDriverWait(driver, timeout);

            if (ignoredExceptionTypes != null)
            {
                wait.IgnoreExceptionTypes(ignoredExceptionTypes);
            }

            if (timeoutMessage != string.Empty)
            {
                wait.Message = timeoutMessage;
            }

            return wait;
        }

        /// <summary>To be added...</summary>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="clock">An object used to determine when time has passed.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        /// <param name="sleepInterval">A value indicating how often to check for the condition to be true.</param>
        public static WebDriverWait Wait(this ISearchContext searchContext, TimeSpan timeout, IClock clock,
            TimeSpan sleepInterval, string timeoutMessage = "", Type[] ignoredExceptionTypes = null)
        {
            var driver = GetDriver(searchContext);

            var wait = new WebDriverWait(clock, driver, timeout, sleepInterval);

            if (ignoredExceptionTypes != null)
            {
                wait.IgnoreExceptionTypes(ignoredExceptionTypes);
            }

            if (timeoutMessage != string.Empty)
            {
                wait.Message = timeoutMessage;
            }

            return wait;
        }
    }
}