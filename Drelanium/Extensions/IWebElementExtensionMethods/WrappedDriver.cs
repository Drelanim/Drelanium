using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>To be added...</summary>
    public static class WrappedDriver
    {
        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebDriver Driver(this IWebElement element)
        {
            return ((RemoteWebElement) element).WrappedDriver;
        }
    }
}