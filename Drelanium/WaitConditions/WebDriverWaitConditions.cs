using System;
using System.Text.RegularExpressions;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using Drelanium.WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global

namespace Drelanium.WaitConditions
{
    /// <summary>
    ///     Collection of methods, that provides exit condition for the <see cref="WebDriverWait" /> type's Until(
    ///     <see cref="Func{T,TResult}" />) method.
    /// </summary>
    public static class WebDriverWaitCondition
    {
        /// <summary>
        ///     The Document.readyState property should be equal to the given value.
        /// </summary>
        /// <param name="documentReadyState">The Document.readyState property describes the loading state of the document.</param>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, bool> DocumentReadyStateToBe(DocumentReadyState documentReadyState)
        {
            return driver => driver.Document().ReadyState == documentReadyState;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, TResult> Element<TResult>(IWebElement element,
            Func<IWebElement, TResult> condition)
        {
            return driver => condition(element);
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, TResult> Element<TResult>(By locator, Func<IWebElement, TResult> condition)
        {
            return driver => condition(driver.FindElement(locator));
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, TResult> Element<TResult>(ISearchContext searchContext, By locator,
            Func<IWebElement, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(By locator, string attributeName,
            Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(ISearchContext searchContext, By locator,
            string attributeName, Func<string, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator).Attributes().Get(attributeName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(IWebElement element, string attributeName,
            Func<string, TResult> condition)
        {
            return driver => condition(element.Attributes().Get(attributeName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given attribute should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="attributeName">The attribute's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(IWebElement element,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(By locator,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementAttribute<TResult>(ISearchContext searchContext, By locator,
            ElementAttributeName attributeName, Func<string, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator).Attributes().Get(attributeName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given property should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementProperty<TResult>(IWebElement element, string propertyName,
            Func<object, TResult> condition)
        {
            return driver => condition(element.Properties().Get(propertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementProperty<TResult>(By locator, string propertyName,
            Func<object, TResult> condition)
        {
            return driver => condition(driver.FindElement(locator).Properties().Get(propertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementProperty<TResult>(ISearchContext searchContext, By locator,
            string propertyName,
            Func<object, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator).Properties().Get(propertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given property should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementProperty<TResult>(IWebElement element,
            ElementPropertyName propertyName, Func<object, TResult> condition)
        {
            return driver => condition(element.Properties().Get(propertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementProperty<TResult>(By locator,
            ElementPropertyName propertyName, Func<object, TResult> condition)
        {
            return driver => condition(driver.FindElement(locator).Properties().Get(propertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given property should meet the given condition.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="propertyName">The property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementProperty<TResult>(ISearchContext searchContext, By locator,
            ElementPropertyName propertyName, Func<object, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator).Properties().Get(propertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(IWebElement element,
            string stylePropertyName, Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(By locator,
            string stylePropertyName, Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(ISearchContext searchContext, By locator,
            string stylePropertyName, Func<string, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator).Style().Get(stylePropertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" />'s given style property should meet the given condition.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="stylePropertyName">The style property's name of the <see cref="IWebElement" />.</param>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(IWebElement element,
            ElementStylePropertyName stylePropertyName, Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(By locator,
            ElementStylePropertyName stylePropertyName, Func<string, TResult> condition)
        {
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
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        /// <exception cref="WebDriverException"></exception>
        public static Func<IWebDriver, TResult> ElementStyleProperty<TResult>(ISearchContext searchContext, By locator,
            ElementStylePropertyName stylePropertyName, Func<string, TResult> condition)
        {
            return driver => condition(searchContext.FindElement(locator).Style().Get(stylePropertyName));
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Clickable(Displayed and Enabled).
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeClickable(IWebElement element)
        {
            return driver => element.Displayed && element.Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Clickable(Displayed and Enabled).
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeClickable(By locator)
        {
            return driver => driver.FindElement(locator).Displayed && driver.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Clickable(Displayed and Enabled).
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeClickable(ISearchContext searchContext, By locator)
        {
            return driver => searchContext.FindElement(locator).Displayed && searchContext.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Displayed.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeDisplayed(IWebElement element)
        {
            return driver => element.Displayed;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Displayed.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeDisplayed(By locator)
        {
            return driver => driver.FindElement(locator).Displayed;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Displayed.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeDisplayed(ISearchContext searchContext, By locator)
        {
            return driver => searchContext.FindElement(locator).Displayed;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Enabled.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeEnabled(IWebElement element)
        {
            return driver => element.Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Enabled.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeEnabled(By locator)
        {
            return driver => driver.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Enabled.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeEnabled(ISearchContext searchContext, By locator)
        {
            return driver => searchContext.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Clickable(not Displayed or not Enabled).
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotClickable(IWebElement element)
        {
            return driver => !element.Displayed || !element.Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Clickable(not Displayed or not Enabled).
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotClickable(By locator)
        {
            return driver => !driver.FindElement(locator).Displayed || !driver.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Clickable(not Displayed or not Enabled).
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotClickable(ISearchContext searchContext, By locator)
        {
            return driver =>
                !searchContext.FindElement(locator).Displayed || !searchContext.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Displayed.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotDisplayed(IWebElement element)
        {
            return driver => !element.Displayed;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Displayed.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotDisplayed(By locator)
        {
            return driver => !driver.FindElement(locator).Displayed;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Displayed.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotDisplayed(ISearchContext searchContext, By locator)
        {
            return driver => !searchContext.FindElement(locator).Displayed;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Enabled.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotEnabled(IWebElement element)
        {
            return driver => !element.Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Enabled.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotEnabled(By locator)
        {
            return driver => !driver.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Enabled.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotEnabled(ISearchContext searchContext, By locator)
        {
            return driver => !searchContext.FindElement(locator).Enabled;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Selected.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotSelected(IWebElement element)
        {
            return driver => !element.Selected;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Selected.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotSelected(By locator)
        {
            return driver => !driver.FindElement(locator).Selected;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become not Selected.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeNotSelected(ISearchContext searchContext, By locator)
        {
            return driver => !searchContext.FindElement(locator).Selected;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Selected.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeSelected(IWebElement element)
        {
            return driver => element.Selected;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Selected.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeSelected(By locator)
        {
            return driver => driver.FindElement(locator).Selected;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should become Selected.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static Func<IWebDriver, bool> ElementToBecomeSelected(ISearchContext searchContext, By locator)
        {
            return driver => searchContext.FindElement(locator).Selected;
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should disappear(not existing or not Displayed).
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static Func<IWebDriver, bool> ElementToDisappear(By locator)
        {
            return driver =>
            {
                try
                {
                    return driver.FindElement(locator) == null;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
            };
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should disappear(not existing or not Displayed).
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static Func<IWebDriver, bool> ElementToDisappear(ISearchContext searchContext, By locator)
        {
            return driver =>
            {
                try
                {
                    return searchContext.FindElement(locator) == null;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
            };
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should exist.
        /// </summary>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        public static Func<IWebDriver, IWebElement> ElementToExist(ISearchContext searchContext, By locator)
        {
            return driver => searchContext.FindElement(locator);
        }


        /// <summary>
        ///     The <see cref="IWebElement" /> should exist.
        /// </summary>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <exception cref="NoSuchElementException"></exception>
        /// <exception cref="NoSuchElementException"></exception>
        public static Func<IWebDriver, IWebElement> ElementToExist(By locator)
        {
            return driver => driver.FindElement(locator);
        }


        /// <summary>
        ///     The browser's title should meet the condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        public static Func<IWebDriver, TResult> Title<TResult>(Func<string, TResult> condition)
        {
            return driver => condition(driver.Title);
        }


        /// <summary>
        ///     The browser's title should match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> TitleMatches(string regexPattern)
        {
            return driver => new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Title).Success;
        }


        /// <summary>
        ///     The browser's title should not match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> TitleNotMatches(string regexPattern)
        {
            return driver => !new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Title).Success;
        }


        /// <summary>
        ///     The browser's title should be equal to the given value.
        /// </summary>
        /// <param name="title">The title of the current browser window.</param>
        public static Func<IWebDriver, bool> TitleNotToBe(string title)
        {
            return driver => driver.Title != title;
        }


        /// <summary>
        ///     The browser's title should not contain the given value.
        /// </summary>
        /// <param name="titlePart">The title part of the current browser window.</param>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> TitleNotToContain(string titlePart)
        {
            return driver => !driver.Title.Contains(titlePart);
        }


        /// <summary>
        ///     The browser's title should be the given value.
        /// </summary>
        /// <param name="title">The title of the current browser window.</param>
        public static Func<IWebDriver, bool> TitleToBe(string title)
        {
            return driver => driver.Title == title;
        }


        /// <summary>
        ///     The browser's title should contain the given value.
        /// </summary>
        /// <param name="titlePart">The title part of the current browser window.</param>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> TitleToContain(string titlePart)
        {
            return driver => driver.Title.Contains(titlePart);
        }


        /// <summary>
        ///     The browser's loaded Url should meet the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        public static Func<IWebDriver, TResult> Url<TResult>(Func<string, TResult> condition)
        {
            return driver => condition(driver.Url);
        }


        /// <summary>
        ///     The browser's loaded Url should meet the given condition.
        /// </summary>
        /// <param name="condition">The <see cref="Func{T,TResult}" />, that defines the condition until the browser must wait.</param>
        public static Func<IWebDriver, TResult> Url<TResult>(Func<Uri, TResult> condition)
        {
            return driver => condition(driver.Url());
        }


        /// <summary>
        ///     The browser's loaded Url should match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> UrlMatches(string regexPattern)
        {
            return driver => new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Url).Success;
        }


        /// <summary>
        ///     The browser's loaded Url should not match the regular expression.
        /// </summary>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RegexMatchTimeoutException"></exception>
        public static Func<IWebDriver, bool> UrlNotMatches(string regexPattern)
        {
            return driver => !new Regex(regexPattern, RegexOptions.IgnoreCase).Match(driver.Url).Success;
        }


        /// <summary>
        ///     The browser's loaded Url should not be the given value.
        /// </summary>
        /// <param name="url">The URL the browser is currently displaying.</param>
        public static Func<IWebDriver, bool> UrlNotToBe(string url)
        {
            return driver => driver.Url != url;
        }


        /// <summary>
        ///     The browser's loaded Url should not contain the given value.
        /// </summary>
        /// <param name="urlPart">The URL part the browser is currently displaying.</param>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> UrlNotToContain(string urlPart)
        {
            return driver => !driver.Url.Contains(urlPart);
        }


        /// <summary>
        ///     The browser's loaded Url should be the given value.
        /// </summary>
        /// <param name="url">The URL the browser is currently displaying.</param>
        public static Func<IWebDriver, bool> UrlToBe(string url)
        {
            return driver => driver.Url == url;
        }


        /// <summary>
        ///     The browser's loaded Url should contain the given value.
        /// </summary>
        /// <param name="urlPart">The URL part the browser is currently displaying.</param>
        /// <exception cref="ArgumentException"></exception>
        public static Func<IWebDriver, bool> UrlToContain(string urlPart)
        {
            return driver => driver.Url.Contains(urlPart);
        }
    }
}