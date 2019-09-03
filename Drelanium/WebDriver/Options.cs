using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Extended implementation of <see cref="IOptions" />
    /// </summary>
    public class Options : IOptions
    {
        /// <summary>
        ///     <inheritdoc cref="Options" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Options([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            OptionsImplementation = driver.Manage();
        }

        /// <summary>
        ///     <inheritdoc cref="IOptions" />
        /// </summary>
        private IOptions OptionsImplementation { get; }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="IOptions.Timeouts()" />
        /// </summary>
        public ITimeouts Timeouts()
        {
            return OptionsImplementation.Timeouts();
        }

        /// <summary>
        ///     <inheritdoc cref="IOptions.Cookies" />
        /// </summary>
        public ICookieJar Cookies => OptionsImplementation.Cookies;

        /// <summary>
        ///     <inheritdoc cref="IOptions.Window" />
        /// </summary>
        public IWindow Window => OptionsImplementation.Window;

        /// <summary>
        ///     <inheritdoc cref="IOptions.Logs" />
        /// </summary>
        public ILogs Logs => OptionsImplementation.Logs;

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public MouseMoveFollower MouseMoveFollower()
        {
            return new MouseMoveFollower(Driver);
        }
    }
}