using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class Properties
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Properties(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public bool Disabled
        {
            get => Get(ElementPropertyName.Disabled) != null && (bool) Get(ElementPropertyName.Disabled);
            set => Set(ElementPropertyName.Disabled, value);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string InnerText
        {
            get => (string) Get(ElementPropertyName.InnerText);
            set => Set(ElementPropertyName.InnerText, value);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public object Value
        {
            get => Get(ElementPropertyName.Value);
            set => Set(ElementPropertyName.Value, value);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private IWebElement Element { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public object Get(string propertyName)
        {
            return Element.ExecuteJavaScript<object>("return arguments[0][arguments[1]]; ", Element, propertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public object Get(ElementPropertyName elementPropertyName)
        {
            return Get(elementPropertyName.PropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Set(string propertyName, object propertyValue)
        {
            Element.ExecuteJavaScript("arguments[0][arguments[1]] = arguments[2]; ", Element, propertyName,
                propertyValue);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Set(ElementPropertyName elementPropertyName, object propertyValue)
        {
            Set(elementPropertyName.PropertyName, propertyValue);
        }
    }
}