using System;
using JetBrains.Annotations;
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
        public static SauceLabsScripts SauceLabsScripts([NotNull] this IWebDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));

            return new SauceLabsScripts(driver);
        }
    }
}