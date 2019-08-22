using System.Text;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    /// <summary>To be added...</summary>
    public static class SendKeysMethods
    {

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void SendTabKey(this IWebElement element)
        {
            element.SendKeys(Keys.Tab);
        }

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static void SendEnterKey(this IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="content">To be added...</param>
        public static void TypeToTextbox(this IWebElement element, string content)
        {
            element.SendKeys(Keys.End + content);
        }

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="content">To be added...</param>
        public static void TypeToTextboxThenEnter(this IWebElement element, string content)
        {
            element.TypeToTextbox(content);
            element.SendEnterKey();
        }

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="content">To be added...</param>
        public static void TypeToTextboxThenTab(this IWebElement element, string content)
        {
            element.TypeToTextbox(content);
            element.SendTabKey();
        }

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="numberOfCharactersToBeDeleted">To be added...</param>
        public static void DeleteFromEndOfTextbox(this IWebElement element, int numberOfCharactersToBeDeleted)
        {
            var backspaces = new StringBuilder();

            for (var i = 0; i < numberOfCharactersToBeDeleted; i++)
            {
                backspaces.Append(Keys.Backspace);
            }

            TypeToTextbox(element, backspaces.ToString());
        }

        /// <summary>To be added...</summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="text">To be added...</param>
        /// <param name="clearFirst">To be added...</param>
        public static void SendKeys(this IWebElement element, string text, bool clearFirst)
        {
            if (clearFirst)
            {
                element.Clear();
            }

            element.SendKeys(text);
        }

    }

}