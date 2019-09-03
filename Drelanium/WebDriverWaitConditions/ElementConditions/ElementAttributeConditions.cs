using System;
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
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(By locator, string attributeName,
            Func<string, TResult> condition)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.FindElement(locator).Attributes().Get(attributeName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(ISearchContext searchContext, By locator,
            string attributeName, Func<string, TResult> condition)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(searchContext.FindElement(locator).Attributes().Get(attributeName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(IWebElement element, string attributeName,
            Func<string, TResult> condition)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(element.Attributes().Get(attributeName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(IWebElement element,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(element.Attributes().Get(attributeName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(By locator,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(driver.FindElement(locator).Attributes().Get(attributeName));
        }

        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(ISearchContext searchContext, By locator,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));
            if (attributeName == null) throw new ArgumentNullException(nameof(attributeName));
            if (condition == null) throw new ArgumentNullException(nameof(condition));

            return driver => condition(searchContext.FindElement(locator).Attributes().Get(attributeName));
        }
    }
}