using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class JQuery
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public JQuery(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>

        private IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public bool Active => Driver.ExecuteJavaScript<bool>("return jQuery.active == 0.");
    }
}