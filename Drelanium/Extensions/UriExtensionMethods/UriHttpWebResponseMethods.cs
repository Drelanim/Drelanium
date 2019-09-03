using System;
using System.Net;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="Uri" /> types.
    /// </summary>
    public static class UriHttpWebResponseMethods
    {
        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="suppressExceptions">...Description to be added...</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="url">...Description to be added...</param>
        public static HttpWebResponse HttpWebResponse(this Uri url, bool suppressExceptions = false,
            Logger logger = null)
        {
            logger?.Information($"Getting HttpWebResponse on url ({url.AbsoluteUri}).");

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