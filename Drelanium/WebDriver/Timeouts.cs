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


        /// <inheritdoc cref="ITimeouts"/>
        private ITimeouts TimeoutsImplementation { get; }


        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }


        /// <inheritdoc></inheritdoc>
        public TimeSpan ImplicitWait
        {
            get => TimeoutsImplementation.ImplicitWait;
            set => TimeoutsImplementation.ImplicitWait = value;
        }

        /// <inheritdoc></inheritdoc>
        public TimeSpan AsynchronousJavaScript
        {
            get => TimeoutsImplementation.AsynchronousJavaScript;
            set => TimeoutsImplementation.AsynchronousJavaScript = value;
        }

        /// <inheritdoc></inheritdoc>
        public TimeSpan PageLoad
        {
            get => TimeoutsImplementation.PageLoad;
            set => TimeoutsImplementation.PageLoad = value;
        }
    }
}