using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;


namespace Drelanium.WebElement
{

    public class Style
    {

        /// <param name="element">The element.</param>
        public Style(IWebElement element)
        {
            Element = element;
        }

        private IWebElement Element { get; }

        public string GetValue(string stylePropertyName)
        {
            return Element.GetCssValue(stylePropertyName);
        }

        public string GetValue(ElementStylePropertyName elementStylePropertyName)
        {
            return Element.GetCssValue(elementStylePropertyName.PropertyName);
        }

        public string Get(string stylePropertyName)
        {
            return Element.ExecuteJavaScript<object>("return arguments[0].style.getPropertyValue(arguments[1]);", Element, stylePropertyName).ToString();
        }

        public string Get(ElementStylePropertyName elementStylePropertyName)
        {
            return Get(elementStylePropertyName.PropertyName);
        }

        public void Set(string stylePropertyName, object stylePropertyValue)
        {
            Element.ExecuteJavaScript("arguments[0].style.setProperty(arguments[1], arguments[2]);", Element, stylePropertyName, stylePropertyValue);
        }

        public void Set(ElementStylePropertyName elementStylePropertyName, object stylePropertyValue)
        {
            Set(elementStylePropertyName.PropertyName, stylePropertyValue);
        }

        public void Remove(string stylePropertyName)
        {
            Element.ExecuteJavaScript("arguments[0].style.removeProperty(arguments[1]);", Element, stylePropertyName);
        }

        public void Remove(ElementStylePropertyName elementStylePropertyName)
        {
            Remove(elementStylePropertyName.PropertyName);
        }

    }

}