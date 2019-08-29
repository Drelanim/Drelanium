using System;
using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///     Extended implementation of <see cref="ITimeouts" />
    /// </summary>
    public class Timeouts : ITimeouts
    {
        /// <summary>
        ///     <inheritdoc cref="Timeouts" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Timeouts(IWebDriver driver)
        {
            Driver = driver;
            TimeoutsImplementation = driver.Manage().Timeouts();
        }


        /// <summary>
        ///     <inheritdoc cref="ITimeouts" />
        /// </summary>
        private ITimeouts TimeoutsImplementation { get; }


        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }


        /// <summary>
        ///     <inheritdoc cref="ITimeouts.ImplicitWait" />
        /// </summary>
        public TimeSpan ImplicitWait
        {
            get => TimeoutsImplementation.ImplicitWait;
            set => TimeoutsImplementation.ImplicitWait = value;
        }


        /// <summary>
        ///     <inheritdoc cref="ITimeouts.AsynchronousJavaScript" />
        /// </summary>
        public TimeSpan AsynchronousJavaScript
        {
            get => TimeoutsImplementation.AsynchronousJavaScript;
            set => TimeoutsImplementation.AsynchronousJavaScript = value;
        }


        /// <summary>
        ///     <inheritdoc cref="ITimeouts.PageLoad" />
        /// </summary>
        public TimeSpan PageLoad
        {
            get => TimeoutsImplementation.PageLoad;
            set => TimeoutsImplementation.PageLoad = value;
        }
    }
}