using Drelanium.WebDriver;
using OpenQA.Selenium;


namespace Drelanium.Extensions.ITargetLocatorExtensionMethods
{

    public static class ITargetLocatorExtensionMethods
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public static Alert Alert(this ITargetLocator targetLocator, IWebDriver driver)
        {
            return new Alert(driver);
        }

    }

}