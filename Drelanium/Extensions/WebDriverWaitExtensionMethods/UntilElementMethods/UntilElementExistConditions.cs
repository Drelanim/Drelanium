using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementExistConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> exists.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static IWebElement UntilElementExists(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "exists.";

            return wait.Until(WebDriverWaitConditions.ElementToExist(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> exists.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static IWebElement UntilElementExists(this WebDriverWait wait, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "exists.";

            return wait.Until(WebDriverWaitConditions.ElementToExist(locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> not exists.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementNotExists(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "not exists.";

            return wait.Until(WebDriverWaitConditions.ElementToNotExist(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> not exists.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementNotExists(this WebDriverWait wait, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "not exists.";

            return wait.Until(WebDriverWaitConditions.ElementToNotExist(locator));
        }
    }
}