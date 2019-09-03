using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementStylePropertyConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given style property has met the given condition.
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementStyleProperty<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] IWebElement element,
            [NotNull] string stylePropertyName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's style property " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.ElementStyleProperty(element, stylePropertyName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given style property has met the given condition.
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementStyleProperty<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] IWebElement element,
            [NotNull] ElementPropertyName stylePropertyName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return wait.UntilElementStyleProperty(element, stylePropertyName.PropertyName, condition);
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given style property has met the given condition.
        ///     <para>
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementStyleProperty<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext,
            [NotNull] By locator, [NotNull] string stylePropertyName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's style property " +
                            "to meet the given condition.";

            return wait.Until(
                WebDriverWaitConditions.ElementStyleProperty(searchContext, locator, stylePropertyName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given style property has met the given condition.
        ///     <para>
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementStyleProperty<TResult>([NotNull] this WebDriverWait wait,
            [NotNull] By locator,
            [NotNull] string stylePropertyName, [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's style property " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.ElementStyleProperty(locator, stylePropertyName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given style property has met the given condition.
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
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
        public static TResult UntilElementStyleProperty<TResult>(
            [NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext,
            [NotNull] By locator, [NotNull] ElementPropertyName stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return wait.UntilElementStyleProperty(searchContext, locator, stylePropertyName.PropertyName, condition);
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given style property has met the given condition.
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementStyleProperty<TResult>(
            [NotNull] this WebDriverWait wait,
            [NotNull] By locator,
            [NotNull] ElementPropertyName stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return wait.UntilElementStyleProperty(locator, stylePropertyName.PropertyName, condition);
        }
    }
}