using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementSelectedConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not Selected.
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementIsNotSelected([NotNull] this WebDriverWait wait, [NotNull] IWebElement element)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));

            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({element}) element " +
                            "to become not Selected.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeNotSelected(element));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not Selected.
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
        public static bool UntilElementIsNotSelected([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in {searchContext}) element " +
                            "to become not Selected.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeNotSelected(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not Selected.
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
        public static bool UntilElementIsNotSelected([NotNull] this WebDriverWait wait, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in the Document) element " +
                            "to become not Selected.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeNotSelected(locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become Selected.
        ///     <para>Exceptions ignored until timeout: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static bool UntilElementIsSelected([NotNull] this WebDriverWait wait, [NotNull] IWebElement element)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (element == null) throw new ArgumentNullException(nameof(element));

            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({element}) element " +
                            "to become Selected.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeSelected(element));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become Selected.
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
        public static bool UntilElementIsSelected([NotNull] this WebDriverWait wait,
            [NotNull] ISearchContext searchContext, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (searchContext == null) throw new ArgumentNullException(nameof(searchContext));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in {searchContext}) element " +
                            "to become Selected.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeSelected(searchContext, locator));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become Selected.
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
        public static bool UntilElementIsSelected([NotNull] this WebDriverWait wait, [NotNull] By locator)
        {
            if (wait == null) throw new ArgumentNullException(nameof(wait));
            if (locator == null) throw new ArgumentNullException(nameof(locator));

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += " Waited for " +
                            $"({locator} in the Document) element " +
                            "to become Selected.";

            return wait.Until(WebDriverWaitConditions.ElementToBecomeSelected(locator));
        }
    }
}