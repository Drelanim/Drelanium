using Drelanium.WebDriver;
using OpenQA.Selenium;


namespace Drelanium.Extensions.ITargetLocatorExtensionMethods
{

    /// <summary>To be added...</summary>
    public static class ITargetLocatorExtensionMethods
    {

        /// <summary>To be added...</summary>
        /// <param name="targetLocator">To be added...</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static Alert Alert(this ITargetLocator targetLocator, IWebDriver driver)
        {
            return new Alert(driver);
        }

    }

}