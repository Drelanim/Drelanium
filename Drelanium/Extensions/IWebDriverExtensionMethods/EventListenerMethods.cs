using Drelanium.Lists;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium.Extensions.IWebDriverExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class EventListenerMethods
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListener(this IWebDriver driver, string eventType, string functionName)
        {
            driver.AddEventListenerToElement("document", eventType, functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListener(this IWebDriver driver, EventType eventType, string functionName)
        {
            AddEventListener(driver, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, string elementName, string eventType,
            string functionName)
        {
            driver.ExecuteJavaScript($"{elementName}.addEventListener('{eventType}', {functionName}); .");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, string elementName, EventType eventType,
            string functionName)
        {
            AddEventListenerToElement(driver, elementName, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, IWebElement element, string eventType,
            string functionName)
        {
            driver.ExecuteJavaScript($"arguments[0].addEventListener('{eventType}', {functionName}); ", element);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, IWebElement element, EventType eventType,
            string functionName)
        {
            AddEventListenerToElement(driver, element, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListener(this IWebDriver driver, string eventType, string functionName)
        {
            driver.RemoveEventListenerToElement("document", eventType, functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListener(this IWebDriver driver, EventType eventType, string functionName)
        {
            RemoveEventListener(driver, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, string elementName, string eventType,
            string functionName)
        {
            driver.ExecuteJavaScript($"{elementName}.removeEventListener('{eventType}', {functionName}); .");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, string elementName, EventType eventType,
            string functionName)
        {
            RemoveEventListenerToElement(driver, elementName, eventType.ToString(), functionName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, IWebElement element, string eventType,
            string functionName)
        {
            driver.ExecuteJavaScript($"arguments[0].removeEventListener('{eventType}', {functionName}); ", element);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, IWebElement element,
            EventType eventType, string functionName)
        {
            RemoveEventListenerToElement(driver, element, eventType.ToString(), functionName);
        }
    }
}