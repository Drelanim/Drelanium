using System.ComponentModel;
using System.Drawing;
using OpenQA.Selenium;

namespace Drelanium.WebElement
{
    /// <summary>
    ///To be added...</summary>
    public enum ElementPoint
    {
        TopLeftPoint,

        MiddleLeftPoint,

        BottomLeftPoint,

        TopMiddlePoint,

        MiddlePoint,

        BottomMiddlePoint,

        TopRightPoint,

        MiddleRightPoint,

        BottomRightPoint
    }

    /// <summary>
    ///To be added...</summary>
    public class Location
    {
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public Location(IWebElement element)
        {
            Element = element;
        }

        /// <summary>
        ///To be added...</summary>
        private IWebElement Element { get; }

        /// <summary>
        ///To be added...</summary>
        private int Height => Element.Size.Height;

        /// <summary>
        ///To be added...</summary>
        private int Width => Element.Size.Width;

        /// <summary>
        ///To be added...</summary>
        public Point TopLeftPoint => Element.Location;

        /// <summary>
        ///To be added...</summary>
        public Point MiddleLeftPoint => new Point(TopLeftPoint.X, TopLeftPoint.Y + Height / 2);

        /// <summary>
        ///To be added...</summary>
        public Point BottomLeftPoint => new Point(TopLeftPoint.X, TopLeftPoint.Y + Height);

        /// <summary>
        ///To be added...</summary>
        public Point TopMiddlePoint => new Point(TopLeftPoint.X + Width / 2, TopLeftPoint.Y);

        /// <summary>
        ///To be added...</summary>
        public Point MiddlePoint => new Point(TopLeftPoint.X + Width / 2, TopLeftPoint.Y + Height / 2);

        /// <summary>
        ///To be added...</summary>
        public Point BottomMiddlePoint => new Point(TopLeftPoint.X + Width / 2, TopLeftPoint.Y + Height);

        /// <summary>
        ///To be added...</summary>
        public Point TopRightPoint => new Point(TopLeftPoint.X + Width, TopLeftPoint.Y);

        /// <summary>
        ///To be added...</summary>
        public Point MiddleRightPoint => new Point(TopLeftPoint.X + Width, TopLeftPoint.Y + Height / 2);

        /// <summary>
        ///To be added...</summary>
        public Point BottomRightPoint => new Point(TopLeftPoint.X + Width, TopLeftPoint.Y + Height);

        /// <summary>
        ///To be added...</summary>
        public Point Point(ElementPoint point)
        {
            switch (point)
            {
                case ElementPoint.TopLeftPoint:
                    return TopLeftPoint;

                case ElementPoint.MiddleLeftPoint:
                    return MiddleLeftPoint;

                case ElementPoint.BottomLeftPoint:
                    return BottomLeftPoint;

                case ElementPoint.TopMiddlePoint:
                    return TopMiddlePoint;

                case ElementPoint.MiddlePoint:
                    return MiddlePoint;

                case ElementPoint.BottomMiddlePoint:
                    return BottomMiddlePoint;

                case ElementPoint.TopRightPoint:
                    return TopRightPoint;

                case ElementPoint.MiddleRightPoint:
                    return MiddleRightPoint;

                case ElementPoint.BottomRightPoint:
                    return BottomRightPoint;

                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
}