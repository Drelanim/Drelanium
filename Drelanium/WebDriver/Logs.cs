using System.Collections.ObjectModel;
using OpenQA.Selenium;


namespace Drelanium.WebDriver
{

    public class Logs : ILogs
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Logs(IWebDriver driver)
        {
            Driver = driver;
            LogsImplementation = driver.Manage().Logs;
        }

        private ILogs LogsImplementation { get; }
        private IWebDriver Driver { get; }

        public ReadOnlyCollection<LogEntry> GetLog(string logKind)
        {
            return LogsImplementation.GetLog(logKind);
        }

        public ReadOnlyCollection<string> AvailableLogTypes => LogsImplementation.AvailableLogTypes;

    }

}