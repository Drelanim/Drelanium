using Drelanium.WebDriver;
using OpenQA.Selenium;


// ReSharper disable InconsistentNaming

namespace Drelanium.Extensions.IOptionsExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IOptions" /> types.
    /// </summary>
    public static class IOptionsExtensionMethods
    {
        /// <summary>
        ///     <see cref="CookieJar" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static CookieJar Cookies(this IOptions options, IWebDriver driver)
        {
            return new CookieJar(driver);
        }


        /// <summary>
        ///     <see cref="WebDriver.LogsManager" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        public static LogsManager Logs(this IOptions options)
        {
            return new LogsManager(options);
        }


        /// <summary>
        ///     <see cref="WebDriver.MouseMoveFollower" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static MouseMoveFollower MouseMoveFollower(this IOptions options, IWebDriver driver)
        {
            return new MouseMoveFollower(driver);
        }


        /// <summary>
        ///     <see cref="WebDriver.Timeouts" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Timeouts Timeouts(this IOptions options, IWebDriver driver)
        {
            return new Timeouts(driver);
        }


        /// <summary>
        ///     <see cref="WebDriver.Window" />
        /// </summary>
        /// <param name="options">The <see cref="IOptions" /> instance, that  allows the user to set options on the browser.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Window Window(this IOptions options, IWebDriver driver)
        {
            return new Window(driver);
        }
    }
}