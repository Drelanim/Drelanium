using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class EdgeConfiguration
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public EdgeOptions InitialOptions { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string EdgeDriverDirectory { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="configurationRoot">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public EdgeConfiguration Bind([NotNull] IConfigurationRoot configurationRoot)
        {
            if (configurationRoot == null) throw new ArgumentNullException(nameof(configurationRoot));

            configurationRoot.Bind(this);
            return this;
        }

        /// <summary>
        /// </summary>
        /// <param name="jsonPath">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public EdgeConfiguration Bind([NotNull] string jsonPath)
        {
            if (jsonPath == null) throw new ArgumentNullException(nameof(jsonPath));

            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }

        /// <summary>
        /// </summary>
        /// <returns>...Description to be added...</returns>
        public EdgeOptions BuildOptions()
        {
            var options = InitialOptions;

            options.SetLoggingPreference(LogType.Driver, LogLevel.All);
            options.SetLoggingPreference(LogType.Browser, LogLevel.All);
            options.SetLoggingPreference(LogType.Client, LogLevel.All);
            options.SetLoggingPreference(LogType.Profiler, LogLevel.All);
            options.SetLoggingPreference(LogType.Server, LogLevel.All);

            return options;
        }
    }
}