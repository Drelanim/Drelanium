using OpenQA.Selenium;

namespace Drelanium


{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class ViewMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="behavior">...Description to be added...</param>
        /// <param name="block">...Description to be added...</param>
        /// <param name="inline">...Description to be added...</param>
        public static IWebElement ScrollIntoView(this IWebElement element, string behavior = "auto",
            string block = "center", string inline = "center")
        {
            element.ExecuteJavaScript(
                $"arguments[0].scrollIntoView({{behavior: '{behavior}', block: '{block}', inline: '{inline}'}});",
                element);

            return element;
        }
    }
}