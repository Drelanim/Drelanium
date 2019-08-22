// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

using System;
using OpenQA.Selenium;

namespace Drelanium.WebDriverSetup
{
    /// <summary>To be added...</summary>
    public enum BrowserType
    {
        CHROME,

        EDGE,

        FIREFOX,

        INTERNETEXPLROER,

        SAFARI,

        OPERA
    }

    /// <summary>To be added...</summary>
    public enum ExecutionMode
    {
        LOCAL,

        REMOTE
    }

    /// <summary>To be added...</summary>
    public class DriverConfiguration
    {
        /// <summary>To be added...</summary>
        public BrowserType BrowserType { get; set; }

        /// <summary>To be added...</summary>
        public ExecutionMode ExecutionMode { get; set; }

        /// <summary>To be added...</summary>
        public UriBuilder SeleniumGridHubUrl { get; set; }

        /// <summary>To be added...</summary>
        public ChromeConfiguration ChromeConfiguration { get; set; }

        /// <summary>To be added...</summary>
        public EdgeConfiguration EdgeConfiguration { get; set; }

        /// <summary>To be added...</summary>
        public FirefoxConfiguration FirefoxConfiguration { get; set; }

        /// <summary>To be added...</summary>
        public InternetExplorerConfiguration InternetExplorerConfiguration { get; set; }

        /// <summary>To be added...</summary>
        public SafariConfiguration SafariConfiguration { get; set; }

        /// <summary>To be added...</summary>
        public OperaConfiguration OperaConfiguration { get; set; }

        /// <summary>To be added...</summary>
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