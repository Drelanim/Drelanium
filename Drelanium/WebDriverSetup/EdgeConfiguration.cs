using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Drelanium.WebDriverSetup
{
    /// <summary>
 ///To be added...</summary>
    public class EdgeConfiguration
    {
        /// <summary>
 ///To be added...</summary>
        public EdgeOptions InitialOptions { get; set; }

        /// <summary>
 ///To be added...</summary>
        public string EdgeDriverDirectory { get; set; }

        /// <summary>
 ///To be added...</summary>
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