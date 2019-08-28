using Drelanium.WebDriver;
using OpenQA.Selenium;

namespace Drelanium.Extensions.IWebElementExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class ActionMethods
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static ExtendedActions Actions(this IWebElement element)
        {
            return new ExtendedActions(element.Driver());
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="theKey">To be added...</param>
        public static void KeyDownAndUp(this IWebElement element, string theKey)
        {
            element
                .Actions()
                .KeyDown(element, theKey)
                .KeyUp(element, theKey)
                .BuildAndPerform();
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebElement MoveMouseOver(this IWebElement element)
        {
            element
                .Actions()
                .MoveToElement(element)
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebElement MoveMouseOverAndClick(this IWebElement element)
        {
            element
                .Actions()
                .MoveToElement(element)
                .Click()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        public static IWebElement RelativeClick(this IWebElement element, int offsetX, int offsetY)
        {
            element
                .Actions()
                .MoveToElement(element)
                .MoveByOffset(offsetX, offsetY)
                .Click()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        public static IWebElement RelativeRightClick(this IWebElement element, int offsetX, int offsetY)
        {
            element
                .Actions()
                .MoveToElement(element)
                .MoveByOffset(offsetX, offsetY)
                .ContextClick()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebElement RightClick(this IWebElement element)
        {
            element
                .Actions()
                .MoveToElement(element)
                .ContextClick()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        public static IWebElement DragAndDropToOffset(this IWebElement element, int offsetX, int offsetY)
        {
            element
                .Actions()
                .DragAndDropToOffset(element, offsetX, offsetY)
                .BuildAndPerform();

            return element;
        }
    }
}