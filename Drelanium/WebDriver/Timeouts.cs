using System;
using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
 ///To be added...</summary>
    public class Timeouts : ITimeouts
    {
        /// <summary>
 ///To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Timeouts(IWebDriver driver)
        {
            Driver = driver;
            TimeoutsImplementation = driver.Manage().Timeouts();
        }

        /// <summary>
 ///To be added...</summary>
        private ITimeouts TimeoutsImplementation { get; }

        /// <summary>
        /// The browser, that is represented by an <see cref="IWebDriver" /> instance.
        ///</summary>
        private IWebDriver Driver { get; }

        /// <summary>
 ///To be added...</summary>
        public TimeSpan ImplicitWait
        {
            get => TimeoutsImplementation.ImplicitWait;
            set => TimeoutsImplementation.ImplicitWait = value;
        }

        /// <summary>
 ///To be added...</summary>
        public TimeSpan AsynchronousJavaScript
        {
            get => TimeoutsImplementation.AsynchronousJavaScript;
            set => TimeoutsImplementation.AsynchronousJavaScript = value;
        }

        /// <summary>
 ///To be added...</summary>
        public TimeSpan PageLoad
        {
            get => TimeoutsImplementation.PageLoad;
            set => TimeoutsImplementation.PageLoad = value;
        }
    }
}