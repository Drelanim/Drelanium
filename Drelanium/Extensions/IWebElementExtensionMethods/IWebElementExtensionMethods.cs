using System;
using System.Text.RegularExpressions;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.WebElement;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;


// ReSharper disable InconsistentNaming


namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class IWebElementExtensionMethods
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Attributes Attributes(this IWebElement element)
        {
            return new Attributes(element);
        }

        /// <summary>
        ///     Loose focus from the element. The body element will get the focus.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public static void Blur(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to Blur on element ({element})");

            element.ExecuteJavaScript("arguments[0].blur(); ", element);

            logger?.Information("Blur on element was successful");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void Click(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to Click on element ({element})");

            element.Click();

            logger?.Information("Click on element was successful");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public static void Click(this IWebElement element, TimeSpan timeout, Logger logger = null)
        {
            logger?.Information($"Attempting to Click on element ({element})");

            element
                .Wait(timeout,
                    $"Waited ({timeout.TotalSeconds}) seconds until ({element}) element is successfully clicked",
                    new[] {typeof(WebDriverException)})
                .Until(webDriver =>
                {
                    element.Click();
                    return true;
                });

            logger?.Information("Click on element was successful");
        }

        /// <summary>
        ///     Dispatches a HTMLEvent from the global window object on an element.
        /// </summary>
        /// <param name="element">The event will be dispatched on this element.</param>
        /// <param name="eventName">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public static void DispatchEvent(this IWebElement element, string eventName, Logger logger = null)
        {
            logger?.Information($"Attempting to Dispatch event ({eventName}) on element ({element})");

            element.ExecuteJavaScript($"arguments[0].dispatchEvent({eventName}); ", element);

            logger?.Information("Dispatch event on element was successful");
        }

        /// <summary>
        ///     Put focus on the element.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public static void Focus(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to Focus on element ({element})");

            element.ExecuteJavaScript("arguments[0].focus(); ", element);

            logger?.Information("Focus on element was successful");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static string GetWebElementID(this IWebElement element)
        {
            return new Regex("\\d{2,}").Match(element.ToString()).Value;
        }

        /// <summary>
        ///     Performs a JavaScript click() on the element.
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        public static void JSClick(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to JavaScript-Click on element ({element})");

            element.ExecuteJavaScript("arguments[0].click(); ", element);

            logger?.Information("JavaScript-Click on element was successful");
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Location Location(this IWebElement element)
        {
            return new Location(element);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Properties Properties(this IWebElement element)
        {
            return new Properties(element);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static SelectElement Select(this IWebElement element)
        {
            return new SelectElement(element);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Style Style(this IWebElement element)
        {
            return new Style(element);
        }
    }
}