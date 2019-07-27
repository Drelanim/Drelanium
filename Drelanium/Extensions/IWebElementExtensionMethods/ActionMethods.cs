using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class ActionMethods
    {

        /// <param name="element">The element.</param>
        public static Actions Actions(this IWebElement element)
        {
            return new Actions(element.Driver());
        }

        /// <param name="element">The element.</param>
        public static void KeyDownAndUp(this IWebElement element, string theKey)
        {
            element
                .Actions()
                .KeyDown(element, theKey)
                .KeyUp(element, theKey)
                .Build()
                .Perform();
        }

        /// <param name="element">The element.</param>
        public static IWebElement MoveMouseOver(this IWebElement element)
        {
            element
                .Actions()
                .MoveToElement(element)
                .Build()
                .Perform();

            return element;
        }

        /// <param name="element">The element.</param>
        public static IWebElement MoveMouseOverAndClick(this IWebElement element)
        {
            element
                .Actions()
                .MoveToElement(element)
                .Click()
                .Build()
                .Perform();

            return element;
        }

        /// <param name="element">The element.</param>
        public static IWebElement RelativeClick(this IWebElement element, int offsetX, int offsetY)
        {
            element
                .Actions()
                .MoveToElement(element)
                .MoveByOffset(offsetX, offsetY)
                .Click()
                .Build()
                .Perform();

            return element;
        }

        /// <param name="element">The element.</param>
        public static IWebElement RelativeRightClick(this IWebElement element, int offsetX, int offsetY)
        {
            element
                .Actions()
                .MoveToElement(element)
                .MoveByOffset(offsetX, offsetY)
                .ContextClick()
                .Build()
                .Perform();

            return element;
        }

        /// <param name="element">The element.</param>
        public static IWebElement RightClick(this IWebElement element)
        {
            element
                .Actions()
                .MoveToElement(element)
                .ContextClick()
                .Build()
                .Perform();

            return element;
        }

        /// <param name="element">The element.</param>
        public static IWebElement DragAndDropToOffset(this IWebElement element, int offsetX, int offsetY)
        {
            element
                .Actions()
                .DragAndDropToOffset(element, offsetX, offsetY)
                .Build()
                .Perform();

            return element;
        }

    }

}