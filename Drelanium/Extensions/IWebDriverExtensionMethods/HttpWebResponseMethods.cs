using System;
using System.Net;
using Drelanium.Extensions.UriExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.Extensions.IWebDriverExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebDriver" /> types.
    /// </summary>
    public static class HttpWebResponseMethods
    {
        /// <summary>
        /// </summary>
        /// <inheritdoc cref="System.Net.HttpWebResponse" />
        /// <param name="url">To be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebResponse HttpWebResponse(this IWebDriver driver, Uri url, Logger logger = null)
        {
            logger?.Information($"Getting HttpWebResponse using url: ({url.AbsoluteUri})");

            return url.HttpWebResponse();
        }


        /// <summary>
        /// </summary>
        /// <inheritdoc cref="System.Net.HttpWebResponse" />
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (level = Information) during
        ///     the method exeuction.
        /// </param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebResponse HttpWebResponse(this IWebDriver driver, Logger logger = null)
        {
            logger?.Information("Getting HttpWebResponse on the WebDriver's current url");

            return driver.Url().HttpWebResponse();
        }
    }
}