using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class EventListenerMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListener([NotNull] this IWebDriver driver, [NotNull] string eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            driver.AddEventListenerToElement("document", eventType, functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListener([NotNull] this IWebDriver driver, EventType eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            AddEventListener(driver, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] string elementName,
            [NotNull] string eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (elementName == null) throw new ArgumentNullException(nameof(elementName));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            driver.ExecuteJavaScript($"{elementName}.addEventListener('{eventType}', {functionName}); ");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] string elementName,
            EventType eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (elementName == null) throw new ArgumentNullException(nameof(elementName));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            AddEventListenerToElement(driver, elementName, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] IWebElement element,
            [NotNull] string eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            driver.ExecuteJavaScript($"arguments[0].addEventListener('{eventType}', {functionName}); ", element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] IWebElement element,
            EventType eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            AddEventListenerToElement(driver, element, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListener([NotNull] this IWebDriver driver, [NotNull] string eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            driver.RemoveEventListenerToElement("document", eventType, functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListener([NotNull] this IWebDriver driver, EventType eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            RemoveEventListener(driver, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] string elementName,
            [NotNull] string eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (elementName == null) throw new ArgumentNullException(nameof(elementName));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            driver.ExecuteJavaScript($"{elementName}.removeEventListener('{eventType}', {functionName}); ");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] string elementName,
            EventType eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (elementName == null) throw new ArgumentNullException(nameof(elementName));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            RemoveEventListenerToElement(driver, elementName, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] IWebElement element,
            [NotNull] string eventType,
            [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            driver.ExecuteJavaScript($"arguments[0].removeEventListener('{eventType}', {functionName}); ", element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement([NotNull] this IWebDriver driver, [NotNull] IWebElement element,
            EventType eventType, [NotNull] string functionName)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));

            RemoveEventListenerToElement(driver, element, eventType.ToString(), functionName);
        }
    }
}