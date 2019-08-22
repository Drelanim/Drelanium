using System;
using System.Net;
using Drelanium.Extensions.UriExtensionMethods;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium.Extensions.IWebDriverExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="IWebDriver"/> types.
    ///</summary>
    public static class HttpWebRequestMethods
    {
        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="url">The URL to load.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebRequest HttpWebRequest(this IWebDriver driver, Uri url, Logger logger = null)
        {
            logger?.Information($"Getting HttWebRequest using url: ({url.AbsoluteUri})");

            return url.HttpWebRequest();
        }

        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static HttpWebRequest HttpWebRequest(this IWebDriver driver, Logger logger = null)
        {
            logger?.Information("Getting HttWebRequest on the WebDriver's current url");

            return driver.Url().HttpWebRequest();
        }
    }
}