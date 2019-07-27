using System;
using OpenQA.Selenium;


namespace Drelanium.WebDriver
{

    public class Timeouts : ITimeouts
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Timeouts(IWebDriver driver)
        {
            Driver = driver;
            TimeoutsImplementation = driver.Manage().Timeouts();
        }

        private ITimeouts TimeoutsImplementation { get; }
        private IWebDriver Driver { get; }

        public TimeSpan ImplicitWait
        {
            get => TimeoutsImplementation.ImplicitWait;
            set => TimeoutsImplementation.ImplicitWait = value;
        }

        public TimeSpan AsynchronousJavaScript
        {
            get => TimeoutsImplementation.AsynchronousJavaScript;
            set => TimeoutsImplementation.AsynchronousJavaScript = value;
        }

        public TimeSpan PageLoad
        {
            get => TimeoutsImplementation.PageLoad;
            set => TimeoutsImplementation.PageLoad = value;
        }

    }

}