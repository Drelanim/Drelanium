using System;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium
{
    /// <summary>
    ///     BaseClass for Selenium TestClasses.
    /// </summary>
    public abstract class BaseTestClass
    {
        /// <summary>
        ///     Gets or sets the currently used <see cref="IWebDriver" />.
        /// </summary>
        public IWebDriver Driver { get; set; }

        /// <summary>
        ///     Gets or sets the currently used <see cref="IPageObject" />.
        /// </summary>
        public IPageObject CurrentPageObject { get; set; }

        /// <summary>
        ///     Gets or sets the currently used <see cref="Serilog.Core.Logger" />.
        /// </summary>
        public Logger Logger { get; set; }

        /// <summary>
        ///     Method, that marks the Test method as incomplete by throwing a <see cref="NotImplementedException" />.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void NotImplementedTest()
        {
            throw new NotImplementedException("Test implementation in is incomplete");
        }
    }
}