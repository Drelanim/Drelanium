using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;


namespace Drelanium.WebElement
{

    public class Properties
    {

        /// <param name="element">The element.</param>
        public Properties(IWebElement element)
        {
            Element = element;
        }

        public string InnerText
        {
            get => Get(ElementAttributeName.InnerText.AttributeName);
            set => Set(ElementAttributeName.InnerText.AttributeName, value);
        }

        private IWebElement Element { get; }

        public string Get(string propertyName)
        {
            return Element.GetAttribute(propertyName);
        }

        public void Set(string propertyName, object propertyValue)
        {
            Element.ExecuteJavaScript("arguments[0][arguments[1]] = arguments[2];", Element, propertyName, propertyValue);
        }

    }

}