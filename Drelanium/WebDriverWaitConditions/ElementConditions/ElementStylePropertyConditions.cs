using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Collection of methods, that provides exit condition for the <see cref="WebDriverWait" /> type's Until(
    ///     <see cref="Func{T,TResult}" />) method.
    /// </summary>
    public static partial class WebDriverWaitConditions
    {
        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(
            [NotNull] IWebElement element,
            [NotNull] string stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(element.Style().Get(stylePropertyName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(
            [NotNull] By locator,
            [NotNull] string stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.FindElement(locator).Style().Get(stylePropertyName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(
            [NotNull] ISearchContext searchContext,
            [NotNull] By locator,
            [NotNull] string stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(searchContext.FindElement(locator).Style().Get(stylePropertyName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(
            [NotNull] IWebElement element,
            [NotNull] ElementStylePropertyName stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(element.Style().Get(stylePropertyName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(
            [NotNull] By locator,
            [NotNull] ElementStylePropertyName stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.FindElement(locator).Style().Get(stylePropertyName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(
            [NotNull] ISearchContext searchContext,
            [NotNull] By locator,
            [NotNull] ElementStylePropertyName stylePropertyName,
            [NotNull] Func<string, TResult> condition)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(searchContext.FindElement(locator).Style().Get(stylePropertyName));
        }
    }
}