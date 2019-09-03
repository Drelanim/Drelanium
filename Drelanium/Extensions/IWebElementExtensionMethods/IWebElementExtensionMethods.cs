using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable InconsistentNaming

namespace Drelanium

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
        public static Attributes Attributes([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

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
        public static void Blur([NotNull] this IWebElement element, [CanBeNull] Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

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
        public static void DispatchEvent([NotNull] this IWebElement element, [NotNull] string eventName,
            [CanBeNull] Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (eventName == null) throw new ArgumentNullException(nameof(eventName));

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
        public static void Focus([NotNull] this IWebElement element, [CanBeNull] Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            logger?.Information($"Attempting to Focus on element ({element}).");

            element.ExecuteJavaScript("arguments[0].focus(); ", element);

            logger?.Information("Focus on element was successful.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static string GetWebElementID([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

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
        public static void JSClick([NotNull] this IWebElement element, [CanBeNull] Logger logger = null)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            logger?.Information($"Attempting to JavaScript-Click on element ({element}).");

            element.ExecuteJavaScript("arguments[0].click(); ", element);

            logger?.Information("JavaScript-Click on element was successful.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Location Location([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new Location(element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Properties Properties([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new Properties(element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static SelectElement Select([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new SelectElement(element);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static Style Style([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new Style(element);
        }
    }
}