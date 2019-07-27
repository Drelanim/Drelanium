using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class RemoveMethods
    {

        /// <param name="element">The element.</param>
        public static void Remove(this IWebElement element)
        {
            element.ExecuteJavaScript("arguments[0].remove();", element);
        }

    }

}