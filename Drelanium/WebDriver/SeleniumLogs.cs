using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class SeleniumLogs
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public SeleniumLogs([NotNull] LogsManager logsManager, [NotNull] string logKind)
        {
            if (logsManager == null) throw new ArgumentNullException(nameof(logsManager));
            LogKind = logKind ?? throw new ArgumentNullException(nameof(logKind));
            Logs = logsManager.GetLog(logKind);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private string LogKind { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private IEnumerable<LogEntry> Logs { get; set; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
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
        ///     ...Description to be added...
        /// </summary>
        /// <param name="logTimeFilter">
        ///     The <see cref="Func{T,TResult}" />, that is applied to filter the LogEntries by their TimeStamp
        ///     property.
        /// </param>
        /// <param name="logLevelFilter">
        ///     The <see cref="Func{T,TResult}" />, that is applied to filter the LogEntries by their LogLevel
        ///     property.
        /// </param>
        /// <param name="logMessageFilter">
        ///     The <see cref="Func{T,TResult}" />, that is applied to filter the LogEntries by their Message
        ///     property.
        /// </param>
        public SeleniumLogs Filter(
            [CanBeNull] Func<DateTime, bool> logTimeFilter = null,
            [CanBeNull] Func<LogLevel, bool> logLevelFilter = null,
            [CanBeNull] Func<string, bool> logMessageFilter = null)
        {
            Logs = Logs
                ?.Where(logEntry => logTimeFilter == null || logTimeFilter(logEntry.Timestamp))
                ?.Where(logEntry => logLevelFilter == null || logLevelFilter(logEntry.Level))
                ?.Where(logEntry => logMessageFilter == null || logMessageFilter(logEntry.Message));

            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public IEnumerable<LogEntry> Get()
        {
            return Logs;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void PrintToLogger([CanBeNull] Logger logger = null)
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