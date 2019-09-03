using System;
using JetBrains.Annotations;
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
        public Create([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
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
        public string CreateElement([NotNull] string elementName, [NotNull] string tagType)
        {
            if (elementName == null) throw new ArgumentNullException(nameof(elementName));
            if (tagType == null) throw new ArgumentNullException(nameof(tagType));

            Driver.ExecuteJavaScript($"window['{elementName}'] = document.createElement('{tagType}'); ");

            return elementName;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="tagType">The used html tag.</param>
        /// <param name="elementName">The variable name for the element that can be used in the window global object.</param>
        public IWebElement CreateElement([NotNull] string elementName, [NotNull] string tagType,
            [NotNull] IWebElement parentElement)
        {
            if (elementName == null) throw new ArgumentNullException(nameof(elementName));
            if (tagType == null) throw new ArgumentNullException(nameof(tagType));
            if (parentElement == null) throw new ArgumentNullException(nameof(parentElement));

            CreateElement(elementName, tagType);

            Driver.AppendElementToParent(parentElement, elementName);

            return Driver.ExecuteJavaScript<IWebElement>($"return {elementName}; ");
        }

        /// <summary>
        ///     Creates a HTMLEvent on the global window object.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="bubbles">The bubbles parameter of the event.</param>
        /// <param name="cancelable">The cancelable parameter of the event.</param>
        public string CreateEvent([NotNull] string eventName, [NotNull] string eventType, bool bubbles = true,
            bool cancelable = false)
        {
            if (eventName == null) throw new ArgumentNullException(nameof(eventName));
            if (eventType == null) throw new ArgumentNullException(nameof(eventType));

            Driver.ExecuteJavaScript($"window['{eventName}'] = document.createEvent('HTMLEvents'); ");
            Driver.ExecuteJavaScript(
                $"{eventName}.initEvent('{eventType}', {bubbles.ToString().ToLower()}, {cancelable.ToString().ToLower()}); ");

            return eventName;
        }

        /// <summary>
        ///     Creates a HTMLEvent on the global window object.
        /// </summary>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="eventType">The type of the event.</param>
        /// <param name="bubbles">The bubbles parameter of the event.</param>
        /// <param name="cancelable">The cancelable parameter of the event.</param>
        public string CreateEvent([NotNull] string eventName, EventType eventType, bool bubbles = true,
            bool cancelable = false)
        {
            if (eventName == null) throw new ArgumentNullException(nameof(eventName));

            return CreateEvent(eventName, eventType.ToString(), bubbles, cancelable);
        }

        /// <summary>
        ///     Creates a new function and adds it to the window global object.
        /// </summary>
        /// <param name="functionName">The name that is used to save the function to the window.</param>
        /// <param name="functionArguments">The arguments of the function.</param>
        /// <param name="functionImplementation">The implementation of the function.</param>
        public string CreateFunction([NotNull] string functionName, [NotNull] string functionArguments = "()",
            [NotNull] string functionImplementation = "{}")
        {
            if (functionName == null) throw new ArgumentNullException(nameof(functionName));
            if (functionArguments == null) throw new ArgumentNullException(nameof(functionArguments));
            if (functionImplementation == null) throw new ArgumentNullException(nameof(functionImplementation));

            Driver.ExecuteJavaScript(
                $"window['{functionName}'] = function{functionArguments} {functionImplementation}; ");

            return functionName;
        }
    }
}