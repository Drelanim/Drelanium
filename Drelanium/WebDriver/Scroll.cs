using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable CommentTypo

namespace Drelanium
{
    /// <summary>
    ///     Methods to perform scroll in the browser.
    /// </summary>
    public class Scroll
    {
        /// <summary>
        ///     Methods to perform scroll in the browser.
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Scroll([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     The method scrolls the document in the window by the given amount of pixels.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        /// <param name="behaviour">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void By(
            int x,
            int y,
            [NotNull] string behaviour = "smooth",
            [CanBeNull] Logger logger = null)
        {
            if (behaviour == null) throw new ArgumentNullException(nameof(behaviour));

            logger?.Information($"Scrolling By({x},{y}).");

            Driver.ExecuteJavaScript($"window.scrollBy({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

        /// <summary>
        ///     The method scrolls to a particular set of pixel coordinates in the document.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="x">The x coordinate in pixel along the horizontal axis of the document.</param>
        /// <param name="y">The y coordinate in pixel along the vertical axis of the document.</param>
        /// <param name="behaviour">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void To(
            int x,
            int y,
            [NotNull] string behaviour = "smooth",
            [CanBeNull] Logger logger = null)
        {
            if (behaviour == null) throw new ArgumentNullException(nameof(behaviour));

            logger?.Information($"Scrolling To({x},{y}).");

            Driver.ExecuteJavaScript($"window.scrollTo({{top: {x}, left: {y}, behaviour: '{behaviour}'}});");
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="behaviour">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void ToBodyBottom(
            [NotNull] string behaviour = "smooth",
            [CanBeNull] Logger logger = null)
        {
            if (behaviour == null) throw new ArgumentNullException(nameof(behaviour));

            logger?.Information("Scrolling to the bottom of the body.");

            Driver.ExecuteJavaScript(
                $"window.scrollTo({{top: document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="behaviour">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void ToBodyTop(
            [NotNull] string behaviour = "smooth",
            [CanBeNull] Logger logger = null)
        {
            if (behaviour == null) throw new ArgumentNullException(nameof(behaviour));

            logger?.Information("Scrolling to the top of the body.");

            Driver.ExecuteJavaScript(
                $"window.scrollTo({{top: -document.body.scrollHeight, left: 0, behaviour: '{behaviour}'}});");
        }
    }
}