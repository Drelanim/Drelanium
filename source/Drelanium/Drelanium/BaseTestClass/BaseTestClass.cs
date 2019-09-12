using System;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium
{
    /// <summary>
    ///     Description to be added...
    /// </summary>
    public abstract class BaseTestClass
    {
        /// <summary>
        ///     Description to be added...
        /// </summary>
        public IWebDriver Driver { get; set; }

        /// <summary>
        ///     Description to be added...
        /// </summary>
        public IPageObject CurrentPageObject { get; set; }

        /// <summary>
        ///     Description to be added...
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