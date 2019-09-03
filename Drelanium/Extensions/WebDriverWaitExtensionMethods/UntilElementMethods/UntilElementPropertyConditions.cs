using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Drelanium
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementPropertyConditions
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given property has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementProperty<TResult>(this WebDriverWait wait, IWebElement element,
            string propertyName, Func<object, TResult> condition)
        {
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's property " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.ElementProperty(element, propertyName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given property has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementProperty<TResult>(this WebDriverWait wait, IWebElement element,
            ElementPropertyName propertyName, Func<object, TResult> condition)
        {
            return wait.UntilElementProperty(element, propertyName.PropertyName, condition);
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given property has met the given condition.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementProperty<TResult>(this WebDriverWait wait, ISearchContext searchContext,
            By locator, string propertyName, Func<object, TResult> condition)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's property " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.ElementProperty(searchContext, locator, propertyName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given property has met the given condition.
        ///     <para>
        ///         Ignored Exceptions: <see cref="NoSuchElementException" />, <see cref="StaleElementReferenceException" />
        ///     </para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementProperty<TResult>(this WebDriverWait wait, By locator, string propertyName,
            Func<object, TResult> condition)
        {
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds for " +
                            "element's property " +
                            "to meet the given condition.";

            return wait.Until(WebDriverWaitConditions.ElementProperty(locator, propertyName, condition));
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given property has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
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
        public static TResult UntilElementProperty<TResult>(this WebDriverWait wait, ISearchContext searchContext,
            By locator, ElementPropertyName propertyName, Func<object, TResult> condition)
        {
            return wait.UntilElementProperty(searchContext, locator, propertyName.PropertyName, condition);
        }

        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given property has met the given condition.
        ///     <para>Ignored Exceptions: <see cref="StaleElementReferenceException" /></para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementProperty<TResult>(this WebDriverWait wait, By locator,
            ElementPropertyName propertyName, Func<object, TResult> condition)
        {
            return wait.UntilElementProperty(locator, propertyName.PropertyName, condition);
        }
    }
}