using System;
using System.Drawing;
using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public static class Highlighter
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        /// <param name="xPosCenter">...Description to be added...</param>
        /// <param name="yPosCenter">...Description to be added...</param>
        public static void ChangePositionForCircle([NotNull] IWebElement circle, int xPosCenter, int yPosCenter)
        {
            if (circle == null) throw new ArgumentNullException(nameof(circle));

            circle.Style().Set(ElementStylePropertyName.Left, $"{xPosCenter - 15}px.");
            circle.Style().Set(ElementStylePropertyName.Top, $"{yPosCenter - 15}px.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        /// <param name="centerPoint">...Description to be added...</param>
        public static void ChangePositionForCircle([NotNull] IWebElement circle, Point centerPoint)
        {
            if (circle == null) throw new ArgumentNullException(nameof(circle));

            ChangePositionForCircle(circle, centerPoint.X, centerPoint.Y);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        /// <param name="text">...Description to be added...</param>
        public static void ChangeTextForCircle([NotNull] IWebElement circle, [CanBeNull] string text)
        {
            if (circle == null) throw new ArgumentNullException(nameof(circle));

            circle.Properties().InnerText = text;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="circleName">...Description to be added...</param>
        /// <param name="text">...Description to be added...</param>
        /// <param name="xPosCenter">...Description to be added...</param>
        /// <param name="yPosCenter">...Description to be added...</param>
        public static IWebElement CreateCircle(
            [NotNull] IWebDriver driver,
            [NotNull] string circleName,
            [CanBeNull] string text,
            int xPosCenter,
            int yPosCenter)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (circleName == null) throw new ArgumentNullException(nameof(circleName));

            var circle = driver.Create().CreateElement(circleName, "div", driver.Body());

            circle.Attributes().Style =
                $"background-color: yellow; position: absolute; left: {xPosCenter - 15}px; top: {yPosCenter - 15}px; height: 24px; width: 24px; border-radius: 50%; border-width: 3px; border-style: solid; z-index: 65535; text-align: center";

            circle.Properties().InnerText = text;

            return circle;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        /// <param name="circleName">...Description to be added...</param>
        /// <param name="text">...Description to be added...</param>
        /// <param name="centerPoint">...Description to be added...</param>
        public static void CreateCircle([NotNull] IWebDriver driver, [NotNull] string circleName, [NotNull] string text,
            Point centerPoint)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            if (circleName == null) throw new ArgumentNullException(nameof(circleName));
            if (text == null) throw new ArgumentNullException(nameof(text));

            CreateCircle(driver, circleName, text, centerPoint.X, centerPoint.Y);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        public static void RemoveCircle([NotNull] IWebElement circle)
        {
            if (circle == null) throw new ArgumentNullException(nameof(circle));

            circle.Remove();
        }
    }
}