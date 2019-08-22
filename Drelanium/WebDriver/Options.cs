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

        /// <summary>
 ///To be added...</summary>
        private IOptions OptionsImplementation { get; }

        /// <summary>
        /// The browser, that is represented by an <see cref="IWebDriver" /> instance.
        ///</summary>
        private IWebDriver Driver { get; }

        /// <summary>
 ///To be added...</summary>
        public ITimeouts Timeouts()
        {
            return OptionsImplementation.Timeouts();
        }

        /// <summary>
 ///To be added...</summary>
        public ICookieJar Cookies => OptionsImplementation.Cookies;

        /// <summary>
 ///To be added...</summary>
        public IWindow Window => OptionsImplementation.Window;

        /// <summary>
 ///To be added...</summary>
        public ILogs Logs => OptionsImplementation.Logs;

        /// <summary>
 ///To be added...</summary>
        public MouseMoveFollower MouseMoveFollower()
        {
            return new MouseMoveFollower(Driver);
        }
    }
}