using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Drelanium

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
        public static void ExecuteJavaScript([NotNull] this IWebElement element, [NotNull] string script,
            params object[] args)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (script == null) throw new ArgumentNullException(nameof(script));

            element.Driver().ExecuteJavaScript(script, args);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="script">...Description to be added...</param>
        /// <param name="args">...Description to be added...</param>
        public static T ExecuteJavaScript<T>([NotNull] this IWebElement element, [NotNull] string script,
            params object[] args)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (script == null) throw new ArgumentNullException(nameof(script));

            return element.Driver().ExecuteJavaScript<T>(script, args);
        }
    }
}