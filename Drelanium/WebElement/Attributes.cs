using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;


// ReSharper disable InconsistentNaming
namespace Drelanium.WebElement
{

    public class Attributes
    {

        /// <param name="element">The element.</param>
        public Attributes(IWebElement element)
        {
            Element = element;
        }

        private IWebElement Element { get; }

        public string Accesskey
        {
            get => Get(ElementAttributeName.Accesskey);
            set => Set(ElementAttributeName.Accesskey, value);
        }

        public string Contenteditable
        {
            get => Get(ElementAttributeName.Contenteditable);
            set => Set(ElementAttributeName.Contenteditable, value);
        }

        public string Contextmenu
        {
            get => Get(ElementAttributeName.Contextmenu);
            set => Set(ElementAttributeName.Contextmenu, value);
        }

        public string Dir
        {
            get => Get(ElementAttributeName.Dir);
            set => Set(ElementAttributeName.Dir, value);
        }

        public string Draggable
        {
            get => Get(ElementAttributeName.Draggable);
            set => Set(ElementAttributeName.Draggable, value);
        }

        public string Hidden
        {
            get => Get(ElementAttributeName.Hidden);
            set => Set(ElementAttributeName.Hidden, value);
        }

        public string Lang
        {
            get => Get(ElementAttributeName.Lang);
            set => Set(ElementAttributeName.Lang, value);
        }

        public string Spellcheck
        {
            get => Get(ElementAttributeName.Spellcheck);
            set => Set(ElementAttributeName.Spellcheck, value);
        }

        public string Tabindex
        {
            get => Get(ElementAttributeName.Tabindex);
            set => Set(ElementAttributeName.Tabindex, value);
        }

        public string Title
        {
            get => Get(ElementAttributeName.Title);
            set => Set(ElementAttributeName.Title, value);
        }

        public string Class
        {
            get => Get(ElementAttributeName.Class);
            set => Set(ElementAttributeName.Class, value);
        }

        public string Value
        {
            get => Get(ElementAttributeName.Value);
            set => Set(ElementAttributeName.Value, value);
        }

        public string Name
        {
            get => Get(ElementAttributeName.Name);
            set => Set(ElementAttributeName.Name, value);
        }

        public string Type
        {
            get => Get(ElementAttributeName.Type);
            set => Set(ElementAttributeName.Type, value);
        }

        public string TagName
        {
            get => Get(ElementAttributeName.TagName);
            set => Set(ElementAttributeName.TagName, value);
        }

        public string Checked
        {
            get => Get(ElementAttributeName.Checked);
            set => Set(ElementAttributeName.Checked, value);
        }

        public string Selected
        {
            get => Get(ElementAttributeName.Selected);
            set => Set(ElementAttributeName.Selected, value);
        }

        public string SelectedIndex
        {
            get => Get(ElementAttributeName.SelectedIndex);
            set => Set(ElementAttributeName.SelectedIndex, value);
        }

        public string Href
        {
            get => Get(ElementAttributeName.Href);
            set => Set(ElementAttributeName.Href, value);
        }

        public string Src
        {
            get => Get(ElementAttributeName.Src);
            set => Set(ElementAttributeName.Src, value);
        }

        public string ReadOnly
        {
            get => Get(ElementAttributeName.ReadOnly);
            set => Set(ElementAttributeName.ReadOnly, value);
        }

        public string Disabled
        {
            get => Get(ElementAttributeName.Disabled);
            set => Set(ElementAttributeName.Disabled, value);
        }

        public string Style
        {
            get => Get(ElementAttributeName.Style);
            set => Set(ElementAttributeName.Style, value);
        }

        public string ID
        {
            get => Get(ElementAttributeName.ID);
            set => Set(ElementAttributeName.ID, value);
        }

        /// <param name="attributeName">Name of the attribute of the element.</param>
        public string Get(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public string Get(ElementAttributeName elementAttributeName)
        {
            return Get(elementAttributeName.AttributeName);
        }

        /// <param name="attributeName">Name of the attribute of the element.</param>
        public void Set(string attributeName, object attributeValue)
        {
            Element.ExecuteJavaScript("arguments[0].setAttribute(arguments[1], arguments[2]);", Element, attributeName, attributeValue);
        }

        public void Set(ElementAttributeName elementAttributeName, object attributeValue)
        {
            Set(elementAttributeName.AttributeName, attributeValue);
        }

        /// <param name="attributeName">Name of the attribute of the element.</param>
        public void Remove(string attributeName)
        {
            Element.ExecuteJavaScript("arguments[0].removeAttribute(arguments[1]);", Element, attributeName);
        }

        public void Remove(ElementAttributeName elementAttributeName)
        {
            Remove(elementAttributeName.AttributeName);
        }

    }

}