using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;

namespace Drelanium.WebElement
{
    /// <summary>
    ///     To be added...
    /// </summary>
    public class Properties
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Properties(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public bool Disabled
        {
            get => Get(ElementPropertyName.Disabled) != null && (bool) Get(ElementPropertyName.Disabled);
            set => Set(ElementPropertyName.Disabled, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string InnerText
        {
            get => (string) Get(ElementPropertyName.InnerText);
            set => Set(ElementPropertyName.InnerText, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public object Value
        {
            get => Get(ElementPropertyName.Value);
            set => Set(ElementPropertyName.Value, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        private IWebElement Element { get; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public object Get(string propertyName)
        {
            return Element.ExecuteJavaScript<object>("return arguments[0][arguments[1]]; ", Element, propertyName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public object Get(ElementPropertyName elementPropertyName)
        {
            return Get(elementPropertyName.PropertyName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void Set(string propertyName, object propertyValue)
        {
            Element.ExecuteJavaScript("arguments[0][arguments[1]] = arguments[2]; ", Element, propertyName,
                propertyValue);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void Set(ElementPropertyName elementPropertyName, object propertyValue)
        {
            Set(elementPropertyName.PropertyName, propertyValue);
        }
    }
}