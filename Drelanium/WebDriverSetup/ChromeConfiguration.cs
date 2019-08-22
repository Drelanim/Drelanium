using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Drelanium.WebDriverSetup
{

    /// <summary>To be added...</summary>
    public class ChromeConfiguration
    {

        /// <summary>To be added...</summary>
        public ChromeOptions InitialOptions { get; set; }

        /// <summary>To be added...</summary>
        public string[] Arguments { get; set; }

        /// <summary>To be added...</summary>
        public bool? CapabilityUseAutomationExtension { get; set; }

        /// <summary>To be added...</summary>
        public string ChromeDriverDirectory { get; set; }

        /// <summary>To be added...</summary>
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