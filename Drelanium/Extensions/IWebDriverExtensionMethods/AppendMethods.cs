using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace Drelanium.Extensions.IWebDriverExtensionMethods
{

    public static class AppendMethods
    {

        /// <param name="parentElementName">The variable name for the parent element that can be used in the window global object.</param>
        /// <param name="childElementName">The variable name for the child element that can be used in the window global object.</param>
        /// <param name="driver">The used WebDriver instance.</param>
        public static void AppendElementToParent(this IWebDriver driver, string parentElementName, string childElementName)
        {
            driver.ExecuteJavaScript($"window['{parentElementName}'].appendChild({childElementName}); ");
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElementName">The variable name for the child element that can be used in the window global object.</param>
        public static void AppendElementToParent(this IWebDriver driver, IWebElement parentElement, string childElementName)
        {
            driver.ExecuteJavaScript($"arguments[0].appendChild({childElementName}); ", parentElement);
        }

        /// <param name="driver">The used WebDriver instance.</param>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendElementToParent(this IWebDriver driver, IWebElement parentElement, IWebElement childElement)
        {
            driver.ExecuteJavaScript("arguments[0].appendChild(arguments[1]); ", parentElement, childElement);
        }

    }

}