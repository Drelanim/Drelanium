using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Interface for Page Object Model, that demands to implement <see cref="IWebDriver" /> to interact with the browser,
    ///     <para>and <see cref="ISearchContext" /> to define the scope of the PageObject.</para>
    /// </summary>
    public interface IPageObject
    {
        /// <summary>
        ///     Gets the browser, that is represented by an <see cref="IWebDriver" /> instance.
        /// </summary>
        IWebDriver Driver { get; }

        /// <summary>
        ///     Gets the <see cref="ISearchContext" /> within we search for the elements.
        ///     <para>This property defines the scope of the Page Object.</para>
        /// </summary>
        ISearchContext PageObjectSearchContext { get; }
    }
}