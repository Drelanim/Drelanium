﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Drelanium.WebDriverSetup
{
    /// <summary>
 ///To be added...</summary>
    public class FirefoxConfiguration
    {
        /// <summary>
 ///To be added...</summary>
        public FirefoxOptions InitialOptions { get; set; }

        /// <summary>
 ///To be added...</summary>
        public string[] Arguments { get; set; }

        /// <summary>
 ///To be added...</summary>
        public string FirefoxDriverDirectory { get; set; }

        /// <summary>
 ///To be added...</summary>
        public FirefoxOptions BuildOptions()
        {
            var options = InitialOptions;

            options.SetLoggingPreference(LogType.Driver, LogLevel.All);
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            options.SetLoggingPreference(LogType.Client, LogLevel.All);
            options.SetLoggingPreference(LogType.Profiler, LogLevel.All);
            options.SetLoggingPreference(LogType.Server, LogLevel.All);

            if (Arguments != null)
            {
                options.AddArguments(Arguments);
            }

            return options;
        }
    }
}