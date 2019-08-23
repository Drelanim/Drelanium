using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="IWebElement"/> types.
    ///</summary>
    public static class ExecuteScriptMethods
    {
        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="script">To be added...</param>
        /// <param name="args">To be added...</param>
        public static void ExecuteJavaScript(this IWebElement element, string script, params object[] args)
        {
            element.Driver().ExecuteJavaScript(script, args);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="script">To be added...</param>
        /// <param name="args">To be added...</param>
        public static T ExecuteJavaScript<T>(this IWebElement element, string script, params object[] args)
        {
            return element.Driver().ExecuteJavaScript<T>(script, args);
        }
    }
}