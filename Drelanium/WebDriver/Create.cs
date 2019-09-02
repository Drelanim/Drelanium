using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class Create
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Create(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>

        private IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="tagType">The used html tag.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        public string CreateElement(string elementName, string tagType)
        {
            Driver.ExecuteJavaScript($"window['{elementName}'] = document.createElement('{tagType}'); .");

            return elementName;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="tagType">The used html tag.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        public IWebElement CreateElement(string elementName, string tagType, IWebElement parentElement)
        {
            CreateElement(elementName, tagType);

            Driver.AppendElementToParent(parentElement, elementName);

            return Driver.ExecuteJavaScript<IWebElement>($"return {elementName}; .");
        }

        /// <summary>
        ///     Creates a HTMLEvent on the global window object.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="bubbles">The bubbles parameter of the event.</param>
        /// <param name="cancelable">The cancelable parameter of the event.</param>
        public string CreateEvent(string eventName, string eventType, bool bubbles = true, bool cancelable = false)
        {
            Driver.ExecuteJavaScript($"window['{eventName}'] = document.createEvent('HTMLEvents'); .");
            Driver.ExecuteJavaScript(
                $"{eventName}.initEvent('{eventType}', {bubbles.ToString().ToLower()}, {cancelable.ToString().ToLower()}); .");

            return eventName;
        }

        /// <summary>
        ///     Creates a HTMLEvent on the global window object.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="bubbles">The bubbles parameter of the event.</param>
        /// <param name="cancelable">The cancelable parameter of the event.</param>
        public string CreateEvent(string eventName, EventType eventType, bool bubbles = true, bool cancelable = false)
        {
            return CreateEvent(eventName, eventType.ToString(), bubbles, cancelable);
        }

        /// <summary>
        ///     Creates a new function and adds it to the window global object.
        /// </summary>
        /// <param name="functionName">The name that is used to save the function to the window.</param>
        /// <param name="functionArguments">The arguments of the function.</param>
        /// <param name="functionImplementation">The implementation of the function.</param>
        public string CreateFunction(string functionName, string functionArguments = "()",
            string functionImplementation = "{}")
        {
            Driver.ExecuteJavaScript(
                $"window['{functionName}'] = function{functionArguments} {functionImplementation}; .");

            return functionName;
        }
    }
}