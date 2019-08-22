using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace Drelanium.WebDriverSetup
{
    /// <summary>
 ///To be added...</summary>
    public class OperaConfiguration
    {
        /// <summary>
 ///To be added...</summary>
        public OperaOptions InitialOptions { get; set; }

        /// <summary>
 ///To be added...</summary>
        public string[] Arguments { get; set; }

        /// <summary>
 ///To be added...</summary>
        public string OperaDriverDirectory { get; set; }

        /// <summary>
 ///To be added...</summary>
        public OperaOptions BuildOptions()
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