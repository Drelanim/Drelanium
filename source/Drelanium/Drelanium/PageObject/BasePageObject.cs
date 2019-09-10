using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public abstract class BasePageObject : IPageObject
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver"></param>
        protected BasePageObject([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            PageObjectSearchContext = driver;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver"> ...Description to be added...</param>
        /// <param name="wrapperElementLocator"> ...Description to be added...</param>
        protected BasePageObject([NotNull] IWebDriver driver, [NotNull] By wrapperElementLocator)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));

            if (wrapperElementLocator == null) throw new ArgumentNullException(nameof(wrapperElementLocator));

            PageObjectSearchContext = driver.FindElement(wrapperElementLocator);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="wrapperElement"> ...Description to be added...</param>
        protected BasePageObject([NotNull] IWebElement wrapperElement)
        {
            if (wrapperElement == null) throw new ArgumentNullException(nameof(wrapperElement));

            Driver = ((RemoteWebElement) wrapperElement).WrappedDriver;
            PageObjectSearchContext = wrapperElement;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ISearchContext PageObjectSearchContext { get; }
    }
}