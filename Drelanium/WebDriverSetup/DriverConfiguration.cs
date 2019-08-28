// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

#pragma warning disable 1591

namespace Drelanium.WebDriverSetup
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
    ///     To be added...
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
        ///     To be added...
        /// </summary>
        public UriBuilder SeleniumGridHubUrl { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public ChromeConfiguration ChromeConfiguration { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public EdgeConfiguration EdgeConfiguration { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public FirefoxConfiguration FirefoxConfiguration { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public InternetExplorerConfiguration InternetExplorerConfiguration { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public SafariConfiguration SafariConfiguration { get; set; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public OperaConfiguration OperaConfiguration { get; set; }


        /// <summary>
        /// </summary>
        /// <param name="configurationRoot"></param>
        /// <returns></returns>
        public DriverConfiguration Bind(IConfigurationRoot configurationRoot)
        {
            configurationRoot.Bind(this);
            return this;
        }


        /// <summary>
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <returns></returns>
        public DriverConfiguration Bind(string jsonPath)
        {
            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }

        /// <summary>
        ///     To be added...
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