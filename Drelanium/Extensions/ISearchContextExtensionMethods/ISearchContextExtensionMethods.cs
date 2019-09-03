using System;
using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="ISearchContext" /> types.
    /// </summary>
    public static class ISearchContextExtensionMethods
    {
        /// <summary>
        ///     Gets the <see cref="IWebDriver" /> instance.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="InvalidEnumArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        private static IWebDriver GetDriver(ISearchContext searchContext)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));

            switch (searchContext)
            {
                case IWebDriver driver:
                    return driver;

                case IWebElement element:
                    return element.Driver();

                default:
                    throw new InvalidEnumArgumentException(
                        "The given ISearchContext was neither IWebDriver, neither IWebElement");
            }
        }

        /// <summary>
        ///     <inheritdoc cref="WebDriverWait" />
        /// </summary>
        /// <param name="clock">An object implementing the <see cref="IClock" /> interface used to determine when time has passed.</param>
        /// <param name="sleepIntervalInSeconds">
        ///     A <see cref="TimeSpan" /> value indicating how often to check for the condition to
        ///     be true.
        /// </param>
        /// <param name="timeoutMessage">The message that appears on timeout.</param>
        /// <param name="ignoredExceptionTypes">The Exception types, that are suppressed until until waiting.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="timeoutInSeconds">The timeout value indicating how long to wait for the condition.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static WebDriverWait Wait(
            this ISearchContext searchContext,
            double timeoutInSeconds,
            string timeoutMessage = "", Type[] ignoredExceptionTypes = null, double sleepIntervalInSeconds = 0.5,
            IClock clock = null)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));

            var driver = GetDriver(searchContext);

            var wait = clock != null
                ? new WebDriverWait(clock, driver, TimeSpan.FromSeconds(timeoutInSeconds),
                    TimeSpan.FromSeconds(sleepIntervalInSeconds))
                : new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds))
                {
                    PollingInterval = TimeSpan.FromSeconds(sleepIntervalInSeconds)
                };

            if (ignoredExceptionTypes != null)
            {
                wait.IgnoreExceptionTypes(ignoredExceptionTypes);
            }

            if (!string.IsNullOrEmpty(timeoutMessage))
            {
                wait.Message = timeoutMessage;
            }

            return wait;
        }
    }
}