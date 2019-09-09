using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public interface IPageObject
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        ISearchContext PageObjectSearchContext { get; }
    }
}