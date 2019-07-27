using System.Drawing;
using OpenQA.Selenium;


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class LocationMethods
    {

        /// <param name="element">The element.</param>
        public static Point GetTopLeftPoint(this IWebElement element)
        {
            return element.Location;
        }

        /// <param name="element">The element.</param>
        public static Point GetTopRightPoint(this IWebElement element)
        {
            return new Point(element.Location.X + element.Size.Width, element.Location.Y);
        }

        /// <param name="element">The element.</param>
        public static Point GetBottomLeftPoint(this IWebElement element)
        {
            return new Point(element.Location.X, element.Location.Y + element.Size.Height);
        }

        /// <param name="element">The element.</param>
        public static Point GetBottomRightPoint(this IWebElement element)
        {
            return new Point(element.Location.X + element.Size.Width, element.Location.Y + element.Size.Height);
        }

        /// <param name="element">The element.</param>
        public static Point GetMiddlePoint(this IWebElement element)
        {
            return new Point(element.Location.X + element.Size.Width / 2, element.Location.Y + element.Size.Height / 2);
        }

    }

}