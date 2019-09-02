using System;
using System.Net;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium


{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class HttpWebResponseMethods
    {
        /// <summary>
        ///     <inheritdoc cref="System.Net.HttpWebResponse" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="url">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebResponse HttpWebResponse(this IWebDriver driver, Uri url, Logger logger = null)
        {
            logger?.Information($"Getting HttpWebResponse using url: ({url.AbsoluteUri}).");

            return url.HttpWebResponse();
        }


        /// <summary>
        ///     <inheritdoc cref="System.Net.HttpWebResponse" />
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebResponse HttpWebResponse(this IWebDriver driver, Logger logger = null)
        {
            logger?.Information("Getting HttpWebResponse on the WebDriver's current url.");

            return driver.Url().HttpWebResponse();
        }
    }
}