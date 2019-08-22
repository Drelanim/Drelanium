using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
 ///To be added...</summary>
    public enum SeleniumLogType
    {
        BrowserLogs,

        ClientLogs,

        DriverLogs,

        ProfilerLogs,

        ServerLogs
    }

    /// <summary>
 ///To be added...</summary>
    public class LogsManager : ILogs
    {
        /// <summary>
 ///To be added...</summary>
        public LogsManager(IOptions options)
        {
            LogsImplementation = options.Logs;
        }

        /// <summary>
 ///To be added...</summary>
        private ILogs LogsImplementation { get; }

        /// <summary>
 ///To be added...</summary>
        public SeleniumLogs BrowserLogs => new SeleniumLogs(this, LogType.Browser);

        /// <summary>
 ///To be added...</summary>
        public SeleniumLogs ClientLogs => new SeleniumLogs(this, LogType.Client);

        /// <summary>
 ///To be added...</summary>
        public SeleniumLogs DriverLogs => new SeleniumLogs(this, LogType.Driver);

        /// <summary>
 ///To be added...</summary>
        public SeleniumLogs ProfilerLogs => new SeleniumLogs(this, LogType.Profiler);

        /// <summary>
 ///To be added...</summary>
        public SeleniumLogs ServerLogs => new SeleniumLogs(this, LogType.Server);

        /// <summary>
 ///Determines if there are any "browser" type of logs.</summary>
        public bool HasBrowserLogs => HasLog(LogType.Browser);

        /// <summary>
 ///Determines if there are any "client" type of logs.</summary>
        public bool HasClientLogs => HasLog(LogType.Client);

        /// <summary>
 ///Determines if there are any "driver" type of logs.</summary>
        public bool HasDriverLogs => HasLog(LogType.Driver);

        /// <summary>
 ///Determines if there are any "profiler" type of logs.</summary>
        public bool HasProfilerLogs => HasLog(LogType.Profiler);

        /// <summary>
 ///Determines if there are any "server" type of logs.</summary>
        public bool HasServerLogs => HasLog(LogType.Server);

        /// <summary>
 ///To be added...</summary>
        public ReadOnlyCollection<LogEntry> GetLog(string logKind)
        {
            try
            {
                return LogsImplementation.GetLog(logKind);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
 ///To be added...</summary>
        public ReadOnlyCollection<string> AvailableLogTypes
        {
            get
            {
                try
                {
                    return LogsImplementation.AvailableLogTypes;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="seleniumLogType">The log for which to retrieve the log entries.</param>
        private static string LogKind(SeleniumLogType seleniumLogType)
        {
            switch (seleniumLogType)
            {
                case SeleniumLogType.BrowserLogs:
                    return LogType.Browser;

                case SeleniumLogType.ClientLogs:
                    return LogType.Client;

                case SeleniumLogType.DriverLogs:
                    return LogType.Driver;

                case SeleniumLogType.ProfilerLogs:
                    return LogType.Profiler;

                case SeleniumLogType.ServerLogs:
                    return LogType.Server;

                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="logKind">
        ///     The log for which to retrieve the log entries. Log types can be found in the
        ///     <see cref="T:OpenQA.Selenium.LogType" /> class.
        /// </param>
        public bool HasLog(string logKind)
        {
            return AvailableLogTypes != null && AvailableLogTypes.Contains(logKind);
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="seleniumLogType">The log for which to retrieve the log entries.</param>
        public bool HasLog(SeleniumLogType seleniumLogType)
        {
            return HasLog(LogKind(seleniumLogType));
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="seleniumLogType">The log for which to retrieve the log entries.</param>
        public ReadOnlyCollection<LogEntry> GetLog(SeleniumLogType seleniumLogType)
        {
            return GetLog(LogKind(seleniumLogType));
        }
    }
}