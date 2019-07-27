using Drelanium.WebDriver;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IOptionsExtensionMethods
{

    public static class IOptionsExtensionMethods
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public static CookieJar Cookies(this IOptions options, IWebDriver driver)
        {
            return new CookieJar(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Timeouts Timeouts(this IOptions options, IWebDriver driver)
        {
            return new Timeouts(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Logs Logs(this IOptions options, IWebDriver driver)
        {
            return new Logs(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static Window Window(this IOptions options, IWebDriver driver)
        {
            return new Window(driver);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        public static MouseMoveFollower MouseMoveFollower(this IOptions options, IWebDriver driver)
        {
            return new MouseMoveFollower(driver);
        }

    }

}