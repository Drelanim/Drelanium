using System.Drawing;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.Lists;
using OpenQA.Selenium;

namespace Drelanium.Highlighter
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
        public static void ChangePositionForCircle(IWebElement circle, int xPosCenter, int yPosCenter)
        {
            circle.Style().Set(ElementStylePropertyName.Left, $"{xPosCenter - 15}px.");
            circle.Style().Set(ElementStylePropertyName.Top, $"{yPosCenter - 15}px.");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        /// <param name="centerPoint">...Description to be added...</param>
        public static void ChangePositionForCircle(IWebElement circle, Point centerPoint)
        {
            ChangePositionForCircle(circle, centerPoint.X, centerPoint.Y);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        /// <param name="text">...Description to be added...</param>
        public static void ChangeTextForCircle(IWebElement circle, string text)
        {
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
        public static IWebElement CreateCircle(IWebDriver driver, string circleName, string text, int xPosCenter,
            int yPosCenter)
        {
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
        public static void CreateCircle(IWebDriver driver, string circleName, string text, Point centerPoint)
        {
            CreateCircle(driver, circleName, text, centerPoint.X, centerPoint.Y);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param>...Description to be added...</param>
        /// <param name="circle">...Description to be added...</param>
        public static void RemoveCircle(IWebElement circle)
        {
            circle.Remove();
        }
    }
}