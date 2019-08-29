using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class ExecuteScriptMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="script">...Description to be added...</param>
        /// <param name="args">...Description to be added...</param>
        public static void ExecuteJavaScript(this IWebElement element, string script, params object[] args)
        {
            element.Driver().ExecuteJavaScript(script, args);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="script">...Description to be added...</param>
        /// <param name="args">...Description to be added...</param>
        public static T ExecuteJavaScript<T>(this IWebElement element, string script, params object[] args)
        {
            return element.Driver().ExecuteJavaScript<T>(script, args);
        }
    }
}