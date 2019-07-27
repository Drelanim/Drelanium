using System;
using System.Collections.Generic;
using System.Diagnostics;


// ReSharper disable EmptyGeneralCatchClause
// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming
namespace Drelanium.DriverProcesses
{

    public static class DisposeDriverServices
    {

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

        /// <param name="processLifeSpan">The lifespan of the webdriver processes, that should be killed.</param>
        public static void EndAllWebDriverProcess(TimeSpan processLifeSpan)
        {
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