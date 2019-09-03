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
        ///     The <see cref="IWebElement" /> should become Displayed.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeDisplayed([NotNull] IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return driver => element.Displayed;
        }

        /// <summary>
        ///     The <see cref="IWebElement" /> should become Displayed.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeDisplayed([NotNull] By locator)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            return driver => driver.FindElement(locator).Displayed;
        }

        /// <summary>
        ///     The <see cref="IWebElement" /> should become Displayed.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeDisplayed([NotNull] ISearchContext searchContext,
            [NotNull] By locator)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            return driver => searchContext.FindElement(locator).Displayed;
        }

        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Displayed.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotDisplayed([NotNull] IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return driver => !element.Displayed;
        }

        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Displayed.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotDisplayed([NotNull] By locator)
        {
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            return driver => !driver.FindElement(locator).Displayed;
        }

        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Displayed.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotDisplayed([NotNull] ISearchContext searchContext,
            [NotNull] By locator)
        {
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            return driver => !searchContext.FindElement(locator).Displayed;
        }
    }
}