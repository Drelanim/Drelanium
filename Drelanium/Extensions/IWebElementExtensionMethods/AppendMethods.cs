using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class AppendMethods
    {

        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendChild(this IWebElement parentElement, IWebElement childElement)
        {
            parentElement.Driver().AppendElementToParent(parentElement, childElement);
        }

        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendTo(this IWebElement childElement, IWebElement parentElement)
        {
            AppendChild(parentElement, childElement);
        }

    }

}