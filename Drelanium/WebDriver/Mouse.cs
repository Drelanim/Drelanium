using System;
using System.Drawing;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///To be added...</summary>
    public class Mouse
    {
        /// <summary>
        ///To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Mouse(IWebDriver driver)
        {
            Driver = driver;
        }


        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }

        ///  <summary>
        /// To be added...</summary>
        ///  <param name="y"></param>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        ///  <param name="x"></param>
        public void MoveTo(int x, int y, Logger logger = null)
        {
            Driver.Actions().MoveTo(x, y).BuildAndPerform(logger);
        }

        ///  <summary>
        /// To be added...</summary>
        ///  <param name="point"></param>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void MoveTo(Point point, Logger logger = null)
        {
            MoveTo(point.X, point.Y, logger);
        }

        ///  <summary>
        /// To be added...</summary>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        ///  <param name="condition">The <see cref="Func" />, that defines the condition until the browser must wait.</param>
        ///  <param name="y"></param>
        ///  <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        ///  <param name="x"></param>
        public void MoveToAndWaitUntilCondition(int x, int y, WebDriverWait wait, Func<IWebDriver, bool> condition,
            Logger logger = null)
        {
            Driver.Actions().MoveTo(x, y).BuildAndPerform(wait, condition, logger);
        }

        ///  <summary>
        /// To be added...</summary>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        ///  <param name="condition">The <see cref="Func" />, that defines the condition until the browser must wait.</param>
        ///  <param name="point"></param>
        ///  <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        public void MoveToAndWaitUntilCondition(Point point, WebDriverWait wait, Func<IWebDriver, bool> condition,
            Logger logger = null)
        {
            MoveToAndWaitUntilCondition(point.X, point.Y, wait, condition, logger);
        }

        /// <summary>
        ///To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public void MoveBy(int x, int y, Logger logger = null)
        {
            Driver.Actions().MoveByOffset(x, y).BuildAndPerform(logger);
        }

        ///  <summary>
        /// To be added...</summary>
        ///  <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        ///  <param name="condition">The <see cref="Func" />, that defines the condition until the browser must wait.</param>
        ///  <param name="y"></param>
        ///  <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        ///  <param name="x"></param>
        public void MoveByAndWaitUntilCondition(int x, int y, WebDriverWait wait, Func<IWebDriver, bool> condition,
            Logger logger = null)
        {
            Driver.Actions().MoveByOffset(x, y).BuildAndPerform(wait, condition, logger);
        }
    }
}