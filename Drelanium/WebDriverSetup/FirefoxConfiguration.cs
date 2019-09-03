﻿using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class FirefoxConfiguration
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public FirefoxOptions InitialOptions { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string[] Arguments { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string FirefoxDriverDirectory { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="configurationRoot">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public FirefoxConfiguration Bind(IConfigurationRoot configurationRoot)
        {
            configurationRoot.Bind(this);
            return this;
        }

        /// <summary>
        /// </summary>
        /// <param name="jsonPath">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public FirefoxConfiguration Bind(string jsonPath)
        {
            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
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