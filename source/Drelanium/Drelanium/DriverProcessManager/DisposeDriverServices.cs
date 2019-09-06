using System;
using System.Collections.Generic;
using System.Diagnostics;
using JetBrains.Annotations;
using Serilog.Core;
using Serilog.Events;

// ReSharper disable EmptyGeneralCatchClause
// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming

namespace Drelanium
{
    /// <summary>
    ///     Methods to dispose stuck WebDriver processes
    /// </summary>
    public static class DisposeDriverServices
    {
        /// <summary>
        ///     List of WebDriver process names
        /// </summary>
        private static readonly List<string> _processesToCheck =
            new List<string>
            {
                "opera",
                "chrome",
                "firefox",
                "ie",
                "gecko",
                "phantomjs",
                "edge",
                "microsoftwebdriver",
                "webdriver"
            };

        /// <summary>
        ///     Ends all WebDriver processes, that has been stuck longer, than the given timespan.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="processLifeSpan">The lifespan of the webdriver processes, that should be killed.</param>
        public static void EndAllWebDriverProcess(TimeSpan processLifeSpan, [CanBeNull] Logger logger = null)
        {
            logger?.Information("Attempting to end all WebDriver processes.");

            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                try
                {
                    if (DateTime.Now.Subtract(process.StartTime) > processLifeSpan)
                    {
                        var shouldKill = false;

                        foreach (var processName in _processesToCheck)
                        {
                            if (process.ProcessName.ToLower().Contains(processName))
                            {
                                shouldKill = true;
                                break;
                            }
                        }

                        if (shouldKill)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }
    }
}