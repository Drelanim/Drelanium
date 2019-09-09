using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public interface IPageWidget : IPageObject

    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        By WidgetLocator { get; }
    }
}