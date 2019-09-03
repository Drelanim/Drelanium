using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementDisplayedConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become Displayed.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, IWebElement element)
        {
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to become Displayed.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeDisplayed(element));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become Displayed.
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
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to become Displayed.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeDisplayed(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become Displayed.
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
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to become Displayed.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeDisplayed(locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not Displayed.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, IWebElement element)
        {
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to become not Displayed.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeNotDisplayed(element));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not Displayed.
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
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to become not Displayed.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeNotDisplayed(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not Displayed.
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
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, By locator)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to become not Displayed.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeNotDisplayed(locator));
        }
    }
}