using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Drelanium.WebDriver
{

    public class Options : IOptions
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Options(IWebDriver driver)
        {
           


            Driver = driver;
            OptionsImplementation = driver.Manage();
        }

        private IOptions OptionsImplementation { get; }
        private IWebDriver Driver { get; }

        public ITimeouts Timeouts()
        {
            return OptionsImplementation.Timeouts();
        }

        public ICookieJar Cookies => OptionsImplementation.Cookies;
        public IWindow Window => OptionsImplementation.Window;
        public ILogs Logs => OptionsImplementation.Logs;

        public MouseMoveFollower MouseMoveFollower()
        {
            return new MouseMoveFollower(Driver);
        }

    }

}