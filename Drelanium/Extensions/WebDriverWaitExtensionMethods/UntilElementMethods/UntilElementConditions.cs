using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElement<TResult>(this WebDriverWait wait, IWebElement element,
            Func<IWebElement, TResult> condition)
        {
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.Element(element, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElement<TResult>(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Func<IWebElement, TResult> condition)
        {
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.Element(searchContext, locator, condition));
        }
    }
}