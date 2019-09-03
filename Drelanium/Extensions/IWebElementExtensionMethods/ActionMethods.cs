using System;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium

{
    /// <summary>
    ///     Extension methods for <see cref="IWebElement" /> types.
    /// </summary>
    public static class ActionMethods
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static ExtendedActions Actions([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            return new ExtendedActions(element.Driver());
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        public static IWebElement DragAndDropToOffset([NotNull] this IWebElement element, int offsetX, int offsetY)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element
                .Actions()
                .DragAndDropToOffset(element, offsetX, offsetY)
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="theKey">...Description to be added...</param>
        public static void KeyDownAndUp([NotNull] this IWebElement element, [NotNull] string theKey)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));
            if (theKey == null) throw new ArgumentNullException(nameof(theKey));

            element
                .Actions()
                .KeyDown(element, theKey)
                .KeyUp(element, theKey)
                .BuildAndPerform();
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebElement MoveMouseOver([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element
                .Actions()
                .MoveToElement(element)
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebElement MoveMouseOverAndClick([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element
                .Actions()
                .MoveToElement(element)
                .Click()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        public static IWebElement RelativeClick([NotNull] this IWebElement element, int offsetX, int offsetY)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element
                .Actions()
                .MoveToElement(element)
                .MoveByOffset(offsetX, offsetY)
                .Click()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        public static IWebElement RelativeRightClick([NotNull] this IWebElement element, int offsetX, int offsetY)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element
                .Actions()
                .MoveToElement(element)
                .MoveByOffset(offsetX, offsetY)
                .ContextClick()
                .BuildAndPerform();

            return element;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static IWebElement RightClick([NotNull] this IWebElement element)
        {
            if (element == null) throw new ArgumentNullException(nameof(element));

            element
                .Actions()
                .MoveToElement(element)
                .ContextClick()
                .BuildAndPerform();

            return element;
        }
    }
}