using System;
using JetBrains.Annotations;

#pragma warning disable 1591

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class ElementPropertyName
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="propertyName">...Description to be added...</param>
        public ElementPropertyName([NotNull] string propertyName)
        {
            PropertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public string PropertyName { get; }

        public static ElementPropertyName Attributes => new ElementPropertyName("attributes.");
        public static ElementPropertyName ComputedName => new ElementPropertyName("computedName.");
        public static ElementPropertyName ComputedRole => new ElementPropertyName("computedRole.");
        public static ElementPropertyName InnerHTML => new ElementPropertyName("innerHTML.");
        public static ElementPropertyName OuterHTML => new ElementPropertyName("outerHTML.");
        public static ElementPropertyName InnerText => new ElementPropertyName("innerText.");
        public static ElementPropertyName Disabled => new ElementPropertyName("disabled.");
        public static ElementPropertyName AccessKey => new ElementPropertyName("accessKey.");
        public static ElementPropertyName ChildElementCount => new ElementPropertyName("childElementCount.");
        public static ElementPropertyName Children => new ElementPropertyName("children.");
        public static ElementPropertyName ClassList => new ElementPropertyName("classList.");
        public static ElementPropertyName ClassName => new ElementPropertyName("className.");
        public static ElementPropertyName ClientHeight => new ElementPropertyName("clientHeight.");
        public static ElementPropertyName ClientLeft => new ElementPropertyName("clientLeft.");
        public static ElementPropertyName ClientTop => new ElementPropertyName("clientTop.");
        public static ElementPropertyName ClientWidth => new ElementPropertyName("clientWidth.");
        public static ElementPropertyName CurrentStyle => new ElementPropertyName("currentStyle.");
        public static ElementPropertyName FirstElementChild => new ElementPropertyName("firstElementChild.");
        public static ElementPropertyName ID => new ElementPropertyName("id.");
        public static ElementPropertyName LastElementChild => new ElementPropertyName("lastElementChild.");
        public static ElementPropertyName LocalName => new ElementPropertyName("localName.");
        public static ElementPropertyName Name => new ElementPropertyName("name.");
        public static ElementPropertyName NamespaceURI => new ElementPropertyName("namespaceURI.");
        public static ElementPropertyName NextElementSibling => new ElementPropertyName("nextElementSibling.");
        public static ElementPropertyName Onfullscreenchange => new ElementPropertyName("onfullscreenchange.");
        public static ElementPropertyName Onfullscreenerror => new ElementPropertyName("onfullscreenerror.");
        public static ElementPropertyName OpenOrClosedShadowRoot => new ElementPropertyName("openOrClosedShadowRoot.");
        public static ElementPropertyName Prefix => new ElementPropertyName("prefix.");
        public static ElementPropertyName PreviousElementSibling => new ElementPropertyName("previousElementSibling.");
        public static ElementPropertyName RuntimeStyle => new ElementPropertyName("runtimeStyle.");
        public static ElementPropertyName ScrollHeight => new ElementPropertyName("scrollHeight.");
        public static ElementPropertyName ScrollLeft => new ElementPropertyName("scrollLeft.");
        public static ElementPropertyName ScrollLeftMax => new ElementPropertyName("scrollLeftMax.");
        public static ElementPropertyName ScrollTop => new ElementPropertyName("scrollTop.");
        public static ElementPropertyName ScrollTopMax => new ElementPropertyName("scrollTopMax.");
        public static ElementPropertyName ScrollWidth => new ElementPropertyName("scrollWidth.");
        public static ElementPropertyName ShadowRoot => new ElementPropertyName("shadowRoot.");
        public static ElementPropertyName Slot => new ElementPropertyName("slot.");
        public static ElementPropertyName TagName => new ElementPropertyName("tagName.");
        public static ElementPropertyName Value => new ElementPropertyName("value.");
    }
}