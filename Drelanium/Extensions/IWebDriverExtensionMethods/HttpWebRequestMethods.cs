using System;
using System.Net;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable CommentTypo

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class HttpWebRequestMethods
    {
        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="url">The URL to load.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebRequest HttpWebRequest([NotNull] this IWebDriver driver, [NotNull] Uri url,
            [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (url == null) throw new ArgumentNullException(nameof(url));

            logger?.Information($"Getting HttWebRequest using url: ({url.AbsoluteUri}).");

            return url.HttpWebRequest();
        }

        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebRequest HttpWebRequest([NotNull] this IWebDriver driver, [CanBeNull] Logger logger = null)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            logger?.Information("Getting HttWebRequest on the WebDriver's current url.");

            return driver.Url().HttpWebRequest();
        }
    }
}