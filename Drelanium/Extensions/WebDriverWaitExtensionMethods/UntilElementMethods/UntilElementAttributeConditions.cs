﻿using System;
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
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, IWebElement element,
            string attributeName, Func<string, TResult> condition)
        {
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
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, IWebElement element,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
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
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, ISearchContext searchContext,
            By locator, string attributeName, Func<string, TResult> condition)
        {
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
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, By locator, string attributeName,
            Func<string, TResult> condition)
        {
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
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, ISearchContext searchContext,
            By locator, ElementAttributeName attributeName, Func<string, TResult> condition)
        {
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
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, By locator,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
            return wait.UntilElementAttribute(locator, attributeName.AttributeName, condition);
        }
    }
}