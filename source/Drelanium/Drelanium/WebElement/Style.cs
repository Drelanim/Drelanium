using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Represents the HTMLElement's style properties
    /// </summary>
    public class Style
    {
        /// <summary>
        ///     Represents the HTMLElement's style properties
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Style([NotNull] IWebElement element)
        {
            Element = element ?? throw new ArgumentNullException(nameof(element));
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private IWebElement Element { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string Get([NotNull] string stylePropertyName)
        {
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));

            return Element.ExecuteJavaScript<object>("return arguments[0].style.getPropertyValue(arguments[1]);",
                Element, stylePropertyName).ToString();
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string Get([NotNull] ElementStylePropertyName elementStylePropertyName)
        {
            if (elementStylePropertyName == null) throw new ArgumentNullException(nameof(elementStylePropertyName));

            return Get(elementStylePropertyName.PropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string GetValue([NotNull] string stylePropertyName)
        {
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));

            return Element.GetCssValue(stylePropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string GetValue([NotNull] ElementStylePropertyName elementStylePropertyName)
        {
            if (elementStylePropertyName == null) throw new ArgumentNullException(nameof(elementStylePropertyName));

            return Element.GetCssValue(elementStylePropertyName.PropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Remove([NotNull] string stylePropertyName)
        {
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));

            Element.ExecuteJavaScript("arguments[0].style.removeProperty(arguments[1]);", Element, stylePropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Remove([NotNull] ElementStylePropertyName elementStylePropertyName)
        {
            if (elementStylePropertyName == null) throw new ArgumentNullException(nameof(elementStylePropertyName));

            Remove(elementStylePropertyName.PropertyName);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Set([NotNull] string stylePropertyName, [CanBeNull] object stylePropertyValue)
        {
            if (stylePropertyName == null) throw new ArgumentNullException(nameof(stylePropertyName));

            Element.ExecuteJavaScript("arguments[0].style.setProperty(arguments[1], arguments[2]);", Element,
                stylePropertyName, stylePropertyValue);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void Set([NotNull] ElementStylePropertyName elementStylePropertyName,
            [CanBeNull] object stylePropertyValue)
        {
            if (elementStylePropertyName == null) throw new ArgumentNullException(nameof(elementStylePropertyName));

            Set(elementStylePropertyName.PropertyName, stylePropertyValue);
        }
    }
}