using OpenQA.Selenium;

namespace Drelanium


{
    /// <summary>
    ///     Extension methods for <see cref="ITargetLocator" /> types.
    /// </summary>
    public static class ITargetLocatorExtensionMethods
    {
        /// <summary>
        ///     <inheritdoc cref="Drelanium.Alert" />
        /// </summary>
        /// <param name="targetLocator">   ...Description to be added...</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Alert Alert(this ITargetLocator targetLocator, IWebDriver driver)
        {
            return new Alert(driver);
        }
    }
}