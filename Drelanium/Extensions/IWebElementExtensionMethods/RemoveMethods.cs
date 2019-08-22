using OpenQA.Selenium;

namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="IWebElement"/> types.
    ///</summary>
    public static class RemoveMethods
    {
        /// <summary>
 ///To be added...
 ///</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void Remove(this IWebElement element)
        {
            element.ExecuteJavaScript("arguments[0].remove();", element);
        }
    }
}