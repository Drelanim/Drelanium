using OpenQA.Selenium;

namespace Drelanium.SauceLabs
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public static class IWebDriverExtensionMethods
    {
        /// <summary>
        ///     To be added..
        /// </summary>
        /// <param name="driver">...Description to be added...</param>
        public static SauceLabsScripts SauceLabsScripts(this IWebDriver driver)
        {
            return new SauceLabsScripts(driver);
        }
    }
}