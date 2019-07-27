using Drelanium.Lists;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class EventListenerMethods
    {

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, string elementName, string eventType, string functionName)
        {
            driver.ExecuteJavaScript($"{elementName}.addEventListener('{eventType}', {functionName}); ");
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, string elementName, EventType eventType, string functionName)
        {
            AddEventListenerToElement(driver, elementName, eventType.ToString(), functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The element.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, IWebElement element, string eventType, string functionName)
        {
            driver.ExecuteJavaScript($"arguments[0].addEventListener('{eventType}', {functionName}); ", element);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The element.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListenerToElement(this IWebDriver driver, IWebElement element, EventType eventType, string functionName)
        {
            AddEventListenerToElement(driver, element, eventType.ToString(), functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListener(this IWebDriver driver, string eventType, string functionName)
        {
            driver.AddEventListenerToElement("document", eventType, functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void AddEventListener(this IWebDriver driver, EventType eventType, string functionName)
        {
            AddEventListener(driver, eventType.ToString(), functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, string elementName, string eventType, string functionName)
        {
            driver.ExecuteJavaScript($"{elementName}.removeEventListener('{eventType}', {functionName}); ");
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, string elementName, EventType eventType, string functionName)
        {
            RemoveEventListenerToElement(driver, elementName, eventType.ToString(), functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The element.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, IWebElement element, string eventType, string functionName)
        {
            driver.ExecuteJavaScript($"arguments[0].removeEventListener('{eventType}', {functionName}); ", element);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="element">The element.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListenerToElement(this IWebDriver driver, IWebElement element, EventType eventType, string functionName)
        {
            RemoveEventListenerToElement(driver, element, eventType.ToString(), functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListener(this IWebDriver driver, string eventType, string functionName)
        {
            driver.RemoveEventListenerToElement("document", eventType, functionName);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="functionName">The variable name for the function that can be used in the window global object.</param>
        public static void RemoveEventListener(this IWebDriver driver, EventType eventType, string functionName)
        {
            RemoveEventListener(driver, eventType.ToString(), functionName);
        }

    }

}