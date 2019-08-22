using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium.WebDriver
{
    /// <summary>
 ///To be added...</summary>
    public class SeleniumLogs
    {
        /// <summary>
 ///To be added...</summary>
        public SeleniumLogs(LogsManager logsManager, string logKind)
        {
            LogsManager = logsManager;
            LogKind = logKind;
            Logs = logsManager.GetLog(logKind);
        }

        /// <summary>
 ///To be added...</summary>
        private string LogKind { get; }

        /// <summary>
 ///To be added...</summary>
        private LogsManager LogsManager { get; }

        /// <summary>
 ///To be added...</summary>
        private IEnumerable<LogEntry> Logs { get; set; }

        /// <summary>
 ///To be added...</summary>
        /// <param name="logTimeFilter">
        ///     The <see cref="Func" />, that is applied to filter the LogEntries by their TimeStamp
        ///     property.
        /// </param>
        /// <param name="logLevelFilter">
        ///     The <see cref="Func" />, that is applied to filter the LogEntries by their LogLevel
        ///     property.
        /// </param>
        /// <param name="logMessageFilter">
        ///     The <see cref="Func" />, that is applied to filter the LogEntries by their Message
        ///     property.
        /// </param>
        public SeleniumLogs Filter(Func<DateTime, bool> logTimeFilter = null,
            Func<LogLevel, bool> logLevelFilter = null, Func<string, bool> logMessageFilter = null)
        {
            Logs = Logs
                ?.Where(logEntry => logTimeFilter == null || logTimeFilter(logEntry.Timestamp))
                ?.Where(logEntry => logLevelFilter == null || logLevelFilter(logEntry.Level))
                ?.Where(logEntry => logMessageFilter == null || logMessageFilter(logEntry.Message));

            return this;
        }

        /// <summary>
 ///To be added...</summary>
        public IEnumerable<LogEntry> Get()
        {
            return Logs;
        }

        /// <summary>
 ///To be added...</summary>
        private LogEventLevel DefineLogEventLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.All:
                    return LogEventLevel.Verbose;

                case LogLevel.Debug:
                    return LogEventLevel.Debug;

                case LogLevel.Info:
                    return LogEventLevel.Information;

                case LogLevel.Warning:
                    return LogEventLevel.Warning;

                case LogLevel.Severe:
                    return LogEventLevel.Error;

                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        /// <summary>
 ///To be added...</summary>
        public void PrintToLogger(Logger logger = null)
        {
            if (Logs == null)
            {
                return;
            }

            foreach (var logEntry in Logs)
            {
                logger?.Write(DefineLogEventLevel(logEntry.Level),
                    $"[Source: {LogKind.ToUpper()}] [OriginTime: {logEntry.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")}]: {logEntry.Message.Trim()}");
            }
        }
    }
}