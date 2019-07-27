using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class ExecuteScriptMethods
    {

        /// <param name="element">The element.</param>
        public static void ExecuteJavaScript(this IWebElement element, string script, params object[] args)
        {
            element.Driver().ExecuteJavaScript(script, args);
        }

        /// <param name="element">The element.</param>
        public static T ExecuteJavaScript<T>(this IWebElement element, string script, params object[] args)
        {
            return element.Driver().ExecuteJavaScript<T>(script, args);
        }

    }

}