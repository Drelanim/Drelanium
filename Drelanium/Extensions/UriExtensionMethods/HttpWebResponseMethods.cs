using System;
using System.Net;
using Serilog.Core;

namespace Drelanium.Extensions.UriExtensionMethods
{
    /// <summary>To be added...</summary>
    public static class HttpWebResponseMethods
    {
        /// <summary>To be added...</summary>
        /// <param name="suppressExceptions">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="url">To be added...</param>
        public static HttpWebResponse HttpWebResponse(this Uri url, bool suppressExceptions = false,
            Logger logger = null)
        {
            logger?.Information($"Getting HttpWebResponse on url ({url.AbsoluteUri})");

            try
            {
                url.HttpWebRequest().GetResponse();
            }
            catch (WebException webException)
            {
                if (suppressExceptions)
                {
                    return (HttpWebResponse) webException.Response;
                }

                throw webException;
            }

            return (HttpWebResponse) url.HttpWebRequest().GetResponse();
        }
    }
}