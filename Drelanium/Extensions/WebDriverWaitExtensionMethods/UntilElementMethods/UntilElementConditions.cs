using System;
using JetBrains.Annotations;
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
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElement<TResult>([NotNull] this WebDriverWait wait, [NotNull] IWebElement element,
            [NotNull] Func<IWebElement, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({element}) element " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.Element(element, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has met the given condition.
        ///     <para>
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />,
        ///         <see cref="StaleElementReferenceException" />
        ///     </para>
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
        public static TResult UntilElement<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext, [NotNull] By locator,
            [NotNull] Func<IWebElement, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in {searchContext}) element " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.Element(searchContext, locator, condition));
        }
    }
}