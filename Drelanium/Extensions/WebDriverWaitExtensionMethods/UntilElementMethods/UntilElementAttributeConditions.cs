using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementAttributeConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] IWebElement element,
            [NotNull] string attributeName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's attribute " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.ElementAttribute(element, attributeName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] IWebElement element,
            [NotNull] ElementAttributeName attributeName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return wait.UntilElementAttribute(element, attributeName.AttributeName, condition);
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext,
            [NotNull] By locator, [NotNull] string attributeName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's attribute " +
                            "to meet the given condition.";

            return wait.Until(
                WebDriverWaitConditions.ElementAttribute(searchContext, locator, attributeName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>([NotNull] this WebDriverWait wait, [NotNull] By locator,
            [NotNull] string attributeName,
            [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's attribute " +
                            "to meet the given condition.";

            return wait.Until(
                WebDriverWaitConditions.ElementAttribute(locator, attributeName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext,
            [NotNull] By locator, [NotNull] ElementAttributeName attributeName,
            [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return wait.UntilElementAttribute(searchContext, locator, attributeName.AttributeName, condition);
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>([NotNull] this WebDriverWait wait, [NotNull] By locator,
            [NotNull] ElementAttributeName attributeName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return wait.UntilElementAttribute(locator, attributeName.AttributeName, condition);
        }
    }
}