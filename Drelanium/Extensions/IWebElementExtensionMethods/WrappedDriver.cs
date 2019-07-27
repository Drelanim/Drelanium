using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class WrappedDriver
    {

        /// <param name="element">The element.</param>
        public static IWebDriver Driver(this IWebElement element)
        {
            return ((RemoteWebElement) element).WrappedDriver;
        }

    }

}