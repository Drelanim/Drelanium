using System;
using System.Net;
using JetBrains.Annotations;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="Uri" /> types.
    /// </summary>
    public static class UriHttpWebRequestMethods
    {
        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="url">     ...Description to be added... </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static HttpWebRequest HttpWebRequest([NotNull] this Uri url, [CanBeNull] Logger logger = null)
        {
            if (url == null) throw new ArgumentNullException(nameof(url));

            logger?.Information($"Getting HttpWebRequest on url ({url.AbsoluteUri}).");

            return (HttpWebRequest) WebRequest.Create(url);
        }
    }
}