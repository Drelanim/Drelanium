using System;
using JetBrains.Annotations;
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
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />,
        ///         <see cref="StaleElementReferenceException" />
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
        public static IWebElement UntilElementExists([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in {searchContext}) element " +
                            "to exist.";

            return wait.Until(WebDriverWaitConditions.ElementToExist(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> exists.
        ///     <para>
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />,
        ///         <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static IWebElement UntilElementExists([NotNull] this WebDriverWait wait, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in the Document) element " +
                            "to exist.";

            return wait.Until(WebDriverWaitConditions.ElementToExist(locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> not exists.
        ///     <para>
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />,
        ///         <see cref="StaleElementReferenceException" />
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
        public static bool UntilElementNotExists([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in {searchContext}) element " +
                            "to not exist.";

            return wait.Until(WebDriverWaitConditions.ElementToNotExist(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> not exists.
        ///     <para>
        ///         Exceptions ignored until timeout: <see cref="NoSuchElementException" />,
        ///         <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementNotExists([NotNull] this WebDriverWait wait, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in the Document) element " +
                            "to not exist.";

            return wait.Until(WebDriverWaitConditions.ElementToNotExist(locator));
        }
    }
}