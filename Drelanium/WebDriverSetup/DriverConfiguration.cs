// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

using System;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

#pragma warning disable 1591

namespace Drelanium
{
    /// <summary>
    ///     The type of the selected browser to be automated.
    /// </summary>
    public enum BrowserType
    {
        CHROME,

        /// <summary>
        /// </summary>
        EDGE,

        FIREFOX,

        INTERNETEXPLROER,

        SAFARI,

        OPERA
    }

    /// <summary>
    ///     Switch between local and remote execution.
    /// </summary>
    public enum ExecutionMode
    {
        LOCAL,

        REMOTE
    }

    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class DriverConfiguration
    {
        public DriverConfiguration()
        {
            ChromeConfiguration = new ChromeConfiguration();
            SeleniumGridHubUrl = new UriBuilder();
            EdgeConfiguration = new EdgeConfiguration();
            FirefoxConfiguration = new FirefoxConfiguration();
            InternetExplorerConfiguration = new InternetExplorerConfiguration();
            SafariConfiguration = new SafariConfiguration();
            OperaConfiguration = new OperaConfiguration();
        }

        /// <summary>
        ///     The type of the selected browser to be automated.
        /// </summary>
        public BrowserType BrowserType { get; set; }

        /// <summary>
        ///     Switch between local and remote execution.
        /// </summary>
        public ExecutionMode ExecutionMode { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public UriBuilder SeleniumGridHubUrl { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ChromeConfiguration ChromeConfiguration { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public EdgeConfiguration EdgeConfiguration { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public FirefoxConfiguration FirefoxConfiguration { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public InternetExplorerConfiguration InternetExplorerConfiguration { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public SafariConfiguration SafariConfiguration { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public OperaConfiguration OperaConfiguration { get; set; }

        /// <summary>
        /// </summary>
        /// <param name="configurationRoot">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public DriverConfiguration Bind([NotNull] IConfigurationRoot configurationRoot)
        {
            if (configurationRoot == null) throw new ArgumentNullException(nameof(configurationRoot));

            configurationRoot.Bind(this);
            return this;
        }

        /// <summary>
        /// </summary>
        /// <param name="jsonPath">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public DriverConfiguration Bind([NotNull] string jsonPath)
        {
            if (jsonPath == null) throw new ArgumentNullException(nameof(jsonPath));

            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public DriverOptions BuildDriverOptions()
        {
            switch (BrowserType)
            {
                case BrowserType.CHROME:
                    return ChromeConfiguration.BuildOptions();

                case BrowserType.EDGE:
                    return EdgeConfiguration.BuildOptions();

                case BrowserType.FIREFOX:
                    return FirefoxConfiguration.BuildOptions();

                case BrowserType.INTERNETEXPLROER:
                    return InternetExplorerConfiguration.BuildOptions();

                case BrowserType.SAFARI:
                    return SafariConfiguration.BuildOptions();

                case BrowserType.OPERA:
                    return OperaConfiguration.BuildOptions();

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}