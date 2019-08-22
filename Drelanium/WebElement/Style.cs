﻿using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;

namespace Drelanium.WebElement
{
    /// <summary>
 ///To be added...</summary>
    public class Style
    {
        /// <summary>
 ///To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Style(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
 ///To be added...</summary>
        private IWebElement Element { get; }

        /// <summary>
 ///To be added...</summary>
        public string GetValue(string stylePropertyName)
        {
            return Element.GetCssValue(stylePropertyName);
        }

        /// <summary>
 ///To be added...</summary>
        public string GetValue(ElementStylePropertyName elementStylePropertyName)
        {
            return Element.GetCssValue(elementStylePropertyName.PropertyName);
        }

        /// <summary>
 ///To be added...</summary>
        public string Get(string stylePropertyName)
        {
            return Element.ExecuteJavaScript<object>("return arguments[0].style.getPropertyValue(arguments[1]);",
                Element, stylePropertyName).ToString();
        }

        /// <summary>
 ///To be added...</summary>
        public string Get(ElementStylePropertyName elementStylePropertyName)
        {
            return Get(elementStylePropertyName.PropertyName);
        }

        /// <summary>
 ///To be added...</summary>
        public void Set(string stylePropertyName, object stylePropertyValue)
        {
            Element.ExecuteJavaScript("arguments[0].style.setProperty(arguments[1], arguments[2]);", Element,
                stylePropertyName, stylePropertyValue);
        }

        /// <summary>
 ///To be added...</summary>
        public void Set(ElementStylePropertyName elementStylePropertyName, object stylePropertyValue)
        {
            Set(elementStylePropertyName.PropertyName, stylePropertyValue);
        }

        /// <summary>
 ///To be added...</summary>
        public void Remove(string stylePropertyName)
        {
            Element.ExecuteJavaScript("arguments[0].style.removeProperty(arguments[1]);", Element, stylePropertyName);
        }

        /// <summary>
 ///To be added...</summary>
        public void Remove(ElementStylePropertyName elementStylePropertyName)
        {
            Remove(elementStylePropertyName.PropertyName);
        }
    }
}