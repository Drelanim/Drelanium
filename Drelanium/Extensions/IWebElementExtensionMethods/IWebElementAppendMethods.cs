using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class IWebElementAppendMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendChild(this IWebElement parentElement, IWebElement childElement)
        {
            parentElement.Driver().AppendElementToParent(parentElement, childElement);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendTo(this IWebElement childElement, IWebElement parentElement)
        {
            AppendChild(parentElement, childElement);
        }
    }
}