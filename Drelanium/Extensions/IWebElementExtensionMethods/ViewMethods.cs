using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class ViewMethods
    {

        /// <param name="element">The element.</param>
        public static IWebElement ScrollIntoView(this IWebElement element, string behavior = "auto", string block = "center", string inline = "center")
        {
            element.ExecuteJavaScript($"arguments[0].scrollIntoView({{behavior: '{behavior}', block: '{block}', inline: '{inline}'}});", element);

            return element;
        }

    }

}