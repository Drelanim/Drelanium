using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;


// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
namespace Drelanium.WebElement
{
    /// <summary>
    ///     To be added...
    /// </summary>
    public class Attributes
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Attributes(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        private IWebElement Element { get; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Accesskey
        {
            get => Get(ElementAttributeName.Accesskey);
            set => Set(ElementAttributeName.Accesskey, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Contenteditable
        {
            get => Get(ElementAttributeName.Contenteditable);
            set => Set(ElementAttributeName.Contenteditable, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Contextmenu
        {
            get => Get(ElementAttributeName.Contextmenu);
            set => Set(ElementAttributeName.Contextmenu, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Dir
        {
            get => Get(ElementAttributeName.Dir);
            set => Set(ElementAttributeName.Dir, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Draggable
        {
            get => Get(ElementAttributeName.Draggable);
            set => Set(ElementAttributeName.Draggable, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Hidden
        {
            get => Get(ElementAttributeName.Hidden);
            set => Set(ElementAttributeName.Hidden, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Lang
        {
            get => Get(ElementAttributeName.Lang);
            set => Set(ElementAttributeName.Lang, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Spellcheck
        {
            get => Get(ElementAttributeName.Spellcheck);
            set => Set(ElementAttributeName.Spellcheck, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Tabindex
        {
            get => Get(ElementAttributeName.Tabindex);
            set => Set(ElementAttributeName.Tabindex, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Title
        {
            get => Get(ElementAttributeName.Title);
            set => Set(ElementAttributeName.Title, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Class
        {
            get => Get(ElementAttributeName.Class);
            set => Set(ElementAttributeName.Class, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Value
        {
            get => Get(ElementAttributeName.Value);
            set => Set(ElementAttributeName.Value, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Name
        {
            get => Get(ElementAttributeName.Name);
            set => Set(ElementAttributeName.Name, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Type
        {
            get => Get(ElementAttributeName.Type);
            set => Set(ElementAttributeName.Type, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string TagName
        {
            get => Get(ElementAttributeName.TagName);
            set => Set(ElementAttributeName.TagName, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Checked
        {
            get => Get(ElementAttributeName.Checked);
            set => Set(ElementAttributeName.Checked, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Selected
        {
            get => Get(ElementAttributeName.Selected);
            set => Set(ElementAttributeName.Selected, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string SelectedIndex
        {
            get => Get(ElementAttributeName.SelectedIndex);
            set => Set(ElementAttributeName.SelectedIndex, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Href
        {
            get => Get(ElementAttributeName.Href);
            set => Set(ElementAttributeName.Href, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Src
        {
            get => Get(ElementAttributeName.Src);
            set => Set(ElementAttributeName.Src, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string ReadOnly
        {
            get => Get(ElementAttributeName.ReadOnly);
            set => Set(ElementAttributeName.ReadOnly, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Disabled
        {
            get => Get(ElementAttributeName.Disabled);
            set => Set(ElementAttributeName.Disabled, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Style
        {
            get => Get(ElementAttributeName.Style);
            set => Set(ElementAttributeName.Style, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string ID
        {
            get => Get(ElementAttributeName.ID);
            set => Set(ElementAttributeName.ID, value);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        public string Get(string attributeName)
        {
            return Element.ExecuteJavaScript<string>("return arguments[0].getAttribute(arguments[1]); ", Element,
                attributeName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Get(ElementAttributeName elementAttributeName)
        {
            return Get(elementAttributeName.AttributeName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="attributeValue"></param>
        public void Set(string attributeName, object attributeValue)
        {
            Element.ExecuteJavaScript("arguments[0].setAttribute(arguments[1], arguments[2]); ", Element, attributeName,
                attributeValue);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void Set(ElementAttributeName elementAttributeName, object attributeValue)
        {
            Set(elementAttributeName.AttributeName, attributeValue);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        public void Remove(string attributeName)
        {
            Element.ExecuteJavaScript("arguments[0].removeAttribute(arguments[1]); ", Element, attributeName);
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        public void Remove(ElementAttributeName elementAttributeName)
        {
            Remove(elementAttributeName.AttributeName);
        }
    }
}