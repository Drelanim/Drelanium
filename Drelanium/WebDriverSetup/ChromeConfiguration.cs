using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Drelanium
{
    /// <summary>
    ///     Class to initialize and setup a <see cref="ChromeOptions" /> object.
    /// </summary>
    public class ChromeConfiguration
    {
        /// <summary>
        ///     The initial <see cref="ChromeOptions" /> object.
        /// </summary>
        public ChromeOptions InitialOptions { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string[] Arguments { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public bool? CapabilityUseAutomationExtension { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string ChromeDriverDirectory { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="configurationRoot">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public ChromeConfiguration Bind([NotNull] IConfigurationRoot configurationRoot)
        {
            if (configurationRoot == null) throw new ArgumentNullException(nameof(configurationRoot));

            configurationRoot.Bind(this);
            return this;
        }

        /// <summary>
        /// </summary>
        /// <param name="jsonPath">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public ChromeConfiguration Bind([NotNull] string jsonPath)
        {
            if (jsonPath == null) throw new ArgumentNullException(nameof(jsonPath));

            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ChromeOptions BuildOptions()
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

            if (CapabilityUseAutomationExtension != null)
            {
                options.AddAdditionalCapability("useAutomationExtension", (bool) CapabilityUseAutomationExtension);
            }

            return options;
        }
    }
}