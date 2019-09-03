using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

// ReSharper disable InconsistentNaming

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class IWebElementAppendMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendChild([NotNull] this IWebElement parentElement, [NotNull] IWebElement childElement)
        {
            if (parentElement == null) throw new ArgumentNullException(nameof(parentElement));
            if (childElement == null) throw new ArgumentNullException(nameof(childElement));

            parentElement.Driver().AppendElementToParent(parentElement, childElement);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="parentElement">The parent element.</param>
        /// <param name="childElement">The child element.</param>
        public static void AppendTo([NotNull] this IWebElement childElement, [NotNull] IWebElement parentElement)
        {
            if (childElement == null) throw new ArgumentNullException(nameof(childElement));
            if (parentElement == null) throw new ArgumentNullException(nameof(parentElement));

            AppendChild(parentElement, childElement);
        }
    }
}