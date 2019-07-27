using System.Text;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class SendKeysMethods
    {

        /// <param name="element">The element.</param>
        public static void SendTabKey(this IWebElement element)
        {
            element.SendKeys(Keys.Tab);
        }

        /// <param name="element">The element.</param>
        public static void SendEnterKey(this IWebElement element)
        {
            element.SendKeys(Keys.Enter);
        }

        /// <param name="element">The element.</param>
        public static void TypeToTextbox(this IWebElement element, string content)
        {
            element.SendKeys(Keys.End + content);
        }

        /// <param name="element">The element.</param>
        public static void TypeToTextboxThenEnter(this IWebElement element, string content)
        {
            element.TypeToTextbox(content);
            element.SendEnterKey();
        }

        /// <param name="element">The element.</param>
        public static void TypeToTextboxThenTab(this IWebElement element, string content)
        {
            element.TypeToTextbox(content);
            element.SendTabKey();
        }

        /// <param name="element">The element.</param>
        public static void DeleteFromEndOfTextbox(this IWebElement element, int numberOfCharactersToBeDeleted)
        {
            var backspaces = new StringBuilder();

            for (var i = 0; i < numberOfCharactersToBeDeleted; i++)
            {
                backspaces.Append(Keys.Backspace);
            }

            TypeToTextbox(element, backspaces.ToString());
        }

        /// <param name="element">The element.</param>
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