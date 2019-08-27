using OpenQA.Selenium;

namespace Drelanium.SauceLabs
{
    /// <summary>
    /// 
    /// </summary>
    public static class IWebDriverExtensionMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static SauceLabsScripts SauceLabsScripts(this IWebDriver driver)
        {
            return new SauceLabsScripts(driver);
        }
    }
}