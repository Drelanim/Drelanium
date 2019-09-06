using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Represents the HTMLElement's properties
    /// </summary>
    public class Properties
    {
        /// <summary>
        ///     Represents the HTMLElement's properties
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Properties([NotNull] IWebElement element)
        {
            Element = element ?? throw new ArgumentNullException(nameof(element));
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
        public object Get([NotNull] string propertyName)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            return Element.ExecuteJavaScript<object>("return arguments[0][arguments[1]]; ", Element, propertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public object Get([NotNull] ElementPropertyName elementPropertyName)
        {
            if (elementPropertyName == null) throw new ArgumentNullException(nameof(elementPropertyName));

            return Get(elementPropertyName.PropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Set([NotNull] string propertyName, [CanBeNull] object propertyValue)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            Element.ExecuteJavaScript("arguments[0][arguments[1]] = arguments[2]; ", Element, propertyName,
                propertyValue);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Set([NotNull] ElementPropertyName elementPropertyName, [CanBeNull] object propertyValue)
        {
            if (elementPropertyName == null) throw new ArgumentNullException(nameof(elementPropertyName));

            Set(elementPropertyName.PropertyName, propertyValue);
        }
    }
}