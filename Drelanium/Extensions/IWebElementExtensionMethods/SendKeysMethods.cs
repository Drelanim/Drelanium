using System;
using System.Text;
using JetBrains.Annotations;
using OpenQA.Selenium;

// ReSharper disable IdentifierTypo

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class SendKeysMethods
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="numberOfCharactersToBeDeleted">...Description to be added...</param>
        public static void DeleteFromEndOfTextbox([NotNull] this IWebElement element, int numberOfCharactersToBeDeleted)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            var backspaces = new StringBuilder();

            for (var i = 0; i < numberOfCharactersToBeDeleted; i++)
            {
                backspaces.Append(Keys.Backspace);
            }

            TypeToTextbox(element, backspaces.ToString());
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void SendEnterKey([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element.SendKeys(Keys.Enter);
        }

        /// <summary>
        ///     To be added..
        ///     .
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="text">...Description to be added...</param>
        /// <param name="clearFirst">...Description to be added...</param>
        public static void SendKeys([NotNull] this IWebElement element, [NotNull] string text, bool clearFirst)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (text == null) throw new ArgumentNullException(nameof(text));

            if (clearFirst)
            {
                element.Clear();
            }

            element.SendKeys(text);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void SendTabKey([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element.SendKeys(Keys.Tab);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="content">...Description to be added...</param>
        public static void TypeToTextbox([NotNull] this IWebElement element, [NotNull] string content)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (content == null) throw new ArgumentNullException(nameof(content));

            element.SendKeys(Keys.End + content);
        }

        /// <summary>
        ///     To be added..
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="content">...Description to be added...</param>
        public static void TypeToTextboxThenEnter([NotNull] this IWebElement element, [NotNull] string content)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (content == null) throw new ArgumentNullException(nameof(content));

            element.TypeToTextbox(content);
            element.SendEnterKey();
        }

        /// <summary>
        ///     To be added..
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="content">...Description to be added...</param>
        public static void TypeToTextboxThenTab([NotNull] this IWebElement element, [NotNull] string content)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (content == null) throw new ArgumentNullException(nameof(content));

            element.TypeToTextbox(content);
            element.SendTabKey();
        }
    }
}