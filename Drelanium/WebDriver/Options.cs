using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///To be added...</summary>
    public class Options : IOptions
    {
        /// <summary>
        ///To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Options(IWebDriver driver)
        {
            Driver = driver;
            OptionsImplementation = driver.Manage();
        }


        /// <inheritdoc cref="IOptions"/>
        private IOptions OptionsImplementation { get; }

        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }


        /// <inheritdoc></inheritdoc>
        public ITimeouts Timeouts()
        {
            return OptionsImplementation.Timeouts();
        }

        /// <inheritdoc></inheritdoc>
        public ICookieJar Cookies => OptionsImplementation.Cookies;


        /// <inheritdoc></inheritdoc>
        public IWindow Window => OptionsImplementation.Window;


        /// <inheritdoc></inheritdoc>
        public ILogs Logs => OptionsImplementation.Logs;


        /// <summary>
        ///To be added...</summary>
        public MouseMoveFollower MouseMoveFollower()
        {
            return new MouseMoveFollower(Driver);
        }
    }
}