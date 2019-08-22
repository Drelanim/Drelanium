using OpenQA.Selenium;
using OpenQA.Selenium.IE;


namespace Drelanium.WebDriverSetup
{

    /// <summary>To be added...</summary>
    public class InternetExplorerConfiguration
    {

        /// <summary>To be added...</summary>
        public InternetExplorerOptions InitialOptions { get; set; }

        /// <summary>To be added...</summary>
        public string InternetExplorerDriverDirectory { get; set; }

        /// <summary>To be added...</summary>
        public InternetExplorerOptions BuildOptions()
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