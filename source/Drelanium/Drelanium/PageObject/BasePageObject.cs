using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Drelanium
{
    /// <summary>
    ///     BaseClass for Page Object Model that implements the <see cref="IPageObject" /> interface.
    ///     <para>
    ///         <see cref="IPageObject.Driver" /> and <see cref="IPageObject.PageObjectSearchContext" /> properties are set
    ///         by the chosen constructor.
    ///     </para>
    /// </summary>
    public abstract class BasePageObject : IPageObject
    {
        /// <summary>
        ///     <inheritdoc cref="BasePageObject" />
        ///     This constructor sets the scope of the Page Object (see <see cref="IPageObject.PageObjectSearchContext" />) to be
        ///     the <see cref="IPageObject.Driver" />.
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        protected BasePageObject([NotNull] IWebDriver driver)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));
            PageObjectSearchContext = driver;
        }

        /// <summary>
        ///     <inheritdoc cref="BasePageObject" />
        ///     This constructor sets the scope of the Page Object (see <see cref="IPageObject.PageObjectSearchContext" />) to be
        ///     the <see cref="IWebElement" />,
        ///     by setting it's value with the driver.FindElement(wrapperElementLocator) method.
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="wrapperElementLocator">
        ///     The locator, that is required to find the <see cref="IWebElement" /> in the DOM,
        ///     that defines the scope of this current Page Object.
        /// </param>
        protected BasePageObject([NotNull] IWebDriver driver, [NotNull] By wrapperElementLocator)
        {
            Driver = driver ?? throw new ArgumentNullException(nameof(driver));

            if (wrapperElementLocator == null) throw new ArgumentNullException(nameof(wrapperElementLocator));

            PageObjectSearchContext = driver.FindElement(wrapperElementLocator);
        }

        /// <summary>
        ///     <inheritdoc cref="BasePageObject" />
        ///     This constructor sets the scope of the Page Object (see <see cref="IPageObject.PageObjectSearchContext" />) to be
        ///     the wrapperElement.
        /// </summary>
        /// <param name="wrapperElement">The <see cref="IWebElement" />, that defines the scope of this current Page Object.</param>
        protected BasePageObject([NotNull] IWebElement wrapperElement)
        {
            if (wrapperElement == null) throw new ArgumentNullException(nameof(wrapperElement));

            Driver = ((RemoteWebElement) wrapperElement).WrappedDriver;
            PageObjectSearchContext = wrapperElement;
        }

        /// <summary>
        ///     <inheritdoc cref="IPageObject.Driver" />
        /// </summary>
        public IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="IPageObject.PageObjectSearchContext" />
        /// </summary>
        public ISearchContext PageObjectSearchContext { get; }
    }
}