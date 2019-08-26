using System;
using System.Net;
using Serilog.Core;

namespace Drelanium.Extensions.UriExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="Uri"/> types. 
    /// ///</summary>
    public static class HttpWebRequestMethods
    {
        /// <summary>
        ///To be added...
        /// </summary>
        /// <param name="url">To be added...
        /// </param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public static HttpWebRequest HttpWebRequest(this Uri url, Logger logger = null)
        {
            logger?.Information($"Getting HttpWebRequest on url ({url.AbsoluteUri})");

            return (HttpWebRequest) WebRequest.Create(url);
        }
    }
}