using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Safari;

namespace Drelanium.WebDriverSetup
{
    /// <summary>
    ///     To be added...
    /// </summary>
    public class SafariConfiguration
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        public SafariOptions InitialOptions { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string SafariDriverDirectory { get; set; }


        /// <summary>
        /// </summary>
        /// <param name="configurationRoot">To be added...</param>
        /// <returns>To be added...</returns>
        public SafariConfiguration Bind(IConfigurationRoot configurationRoot)
        {
            configurationRoot.Bind(this);
            return this;
        }


        /// <summary>
        /// </summary>
        /// <param name="jsonPath">To be added...</param>
        /// <returns>To be added...</returns>
        public SafariConfiguration Bind(string jsonPath)
        {
            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public SafariOptions BuildOptions()
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