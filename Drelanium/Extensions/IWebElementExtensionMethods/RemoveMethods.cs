using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    /// <summary>To be added...</summary>
    public static class RemoveMethods
    {

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void Remove(this IWebElement element)
        {
            element.ExecuteJavaScript("arguments[0].remove();", element);
        }

    }

}