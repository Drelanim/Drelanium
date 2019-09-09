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
        protected BasePageObject(IWebDriver driver)
        {
            Driver = driver;
            PageObjectSearchContext = driver;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver"> ...Description to be added...</param>
        /// <param name="wrapperElementLocator"> ...Description to be added...</param>
        protected BasePageObject(IWebDriver driver, By wrapperElementLocator)
        {
            Driver = driver;
            PageObjectSearchContext = driver.FindElement(wrapperElementLocator);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="wrapperElement"> ...Description to be added...</param>
        protected BasePageObject(IWebElement wrapperElement)
        {
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