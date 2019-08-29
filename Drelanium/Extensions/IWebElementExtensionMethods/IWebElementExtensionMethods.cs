using System.Text.RegularExpressions;
using Drelanium.WebElement;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;


// ReSharper disable InconsistentNaming


namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class IWebElementExtensionMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Attributes Attributes(this IWebElement element)
        {
            return new Attributes(element);
        }

        /// <summary>
        ///     Loose focus from the element. The body element will get the focus.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void Blur(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to Blur on element ({element}).");

            element.ExecuteJavaScript("arguments[0].blur(); ", element);

            logger?.Information("Blur on element was successful.");
        }


        /// <summary>
        ///     Dispatches a HTMLEvent from the global window object on an element.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The event will be dispatched on this element.</param>
        /// <param name="eventName">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void DispatchEvent(this IWebElement element, string eventName, Logger logger = null)
        {
            logger?.Information($"Attempting to Dispatch event ({eventName}) on element ({element}).");

            element.ExecuteJavaScript($"arguments[0].dispatchEvent({eventName}); ", element);

            logger?.Information("Dispatch event on element was successful.");
        }

        /// <summary>
        ///     Put focus on the element.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void Focus(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to Focus on element ({element}).");

            element.ExecuteJavaScript("arguments[0].focus(); ", element);

            logger?.Information("Focus on element was successful.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static string GetWebElementID(this IWebElement element)
        {
            return new Regex("\\d{2,}").Match(element.ToString()).Value;
        }

        /// <summary>
        ///     Performs a JavaScript click() on the element.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void JSClick(this IWebElement element, Logger logger = null)
        {
            logger?.Information($"Attempting to JavaScript-Click on element ({element}).");

            element.ExecuteJavaScript("arguments[0].click(); ", element);

            logger?.Information("JavaScript-Click on element was successful.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Location Location(this IWebElement element)
        {
            return new Location(element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Properties Properties(this IWebElement element)
        {
            return new Properties(element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static SelectElement Select(this IWebElement element)
        {
            return new SelectElement(element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Style Style(this IWebElement element)
        {
            return new Style(element);
        }
    }
}