using System;
using System.Drawing;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using Drelanium.Extensions.IWebElementExtensionMethods;
using Drelanium.WebElement;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;

namespace Drelanium.WebDriver
{
    /// <summary>
 ///To be added...</summary>
    public class ExtendedActions
    {
        /// <summary>
 ///To be added...</summary>
        public ExtendedActions(IWebDriver driver)
        {
            Driver = driver;
            Actions = new Actions(driver);
        }




        /// <summary>
        /// The browser, that is represented by an <see cref="IWebDriver" /> instance.
        ///</summary>
        private IWebDriver Driver { get; }

        /// <summary>
 ///To be added...</summary>
        private Actions Actions { get; set; }

        /// <summary>
 ///To be added...</summary>
        private string ChainedActions { get; set; }

        /// <summary>
 ///To be added...</summary>
        /// <param name="theKey">To be added...</param>
        public ExtendedActions KeyDown(string theKey)
        {
            ChainedActions += $"KeyDown(theKey: \"{theKey}\"), ";
            Actions = Actions.KeyDown(theKey);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="element">To be added...</param>
        /// <param name="theKey">To be added...</param>
        public ExtendedActions KeyDown(IWebElement element, string theKey)
        {
            ChainedActions += $"KeyDown(element: {element}, theKey: \"{theKey}\"";
            Actions = Actions.KeyDown(element, theKey);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="theKey">To be added...</param>
        public ExtendedActions KeyUp(string theKey)
        {
            ChainedActions += $"KeyDown(theKey: \"{theKey}\"), ";
            Actions = Actions.KeyUp(theKey);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="element">To be added...</param>
        /// <param name="theKey">To be added...</param>
        public ExtendedActions KeyUp(IWebElement element, string theKey)
        {
            ChainedActions += $"KeyUp(element: {element}, theKey: \"{theKey}\"), ";
            Actions = Actions.KeyUp(element, theKey);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="keysToSend">To be added...</param>
        public ExtendedActions SendKeys(string keysToSend)
        {
            ChainedActions += $"SendKeys(keysToSend: \"{keysToSend}\"), ";
            Actions = Actions.SendKeys(keysToSend);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="element">To be added...</param>
        /// <param name="keysToSend">To be added...</param>
        public ExtendedActions SendKeys(IWebElement element, string keysToSend)
        {
            ChainedActions += $"SendKeys(element: {element}, keysToSend: \"{keysToSend}\"), ";
            Actions = Actions.SendKeys(element, keysToSend);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="onElement">To be added...</param>
        public ExtendedActions ClickAndHold(IWebElement onElement)
        {
            ChainedActions += $"ClickAndHold(onElement: {onElement}), ";
            Actions = Actions.ClickAndHold(onElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="">To be added...</param>
        public ExtendedActions ClickAndHold()
        {
            ChainedActions += "ClickAndHold(), ";
            Actions = Actions.ClickAndHold();
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="onElement">To be added...</param>
        public ExtendedActions Release(IWebElement onElement)
        {
            ChainedActions += $"Release(onElement: {onElement}), ";
            Actions = Actions.Release(onElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="">To be added...</param>
        public ExtendedActions Release()
        {
            ChainedActions += "Release(), ";
            Actions = Actions.Release();
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="onElement">To be added...</param>
        public ExtendedActions Click(IWebElement onElement)
        {
            ChainedActions += $"Click(onElement: {onElement}), ";
            Actions = Actions.Click(onElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="onElement">To be added...</param>
        /// <param name="elementPoint">To be added...</param>
        public ExtendedActions Click(IWebElement onElement, ElementPoint elementPoint)
        {
            MoveToElement(onElement, elementPoint);
            Click(onElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="">To be added...</param>
        public ExtendedActions Click()
        {
            ChainedActions += "Click(), ";
            Actions = Actions.Click();
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="onElement">To be added...</param>
        public ExtendedActions DoubleClick(IWebElement onElement)
        {
            ChainedActions += $"DoubleClick(onElement: {onElement}), ";
            Actions = Actions.DoubleClick(onElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="">To be added...</param>
        public ExtendedActions DoubleClick()
        {
            ChainedActions += "DoubleClick(), ";
            Actions = Actions.DoubleClick();
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="toElement">To be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement)
        {
            ChainedActions += $"MoveToElement(toElement: {toElement}), ";
            Actions = Actions.MoveToElement(toElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="toElement">To be added...</param>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement, int offsetX, int offsetY)
        {
            ChainedActions += $"MoveToElement(toElement: {toElement}, offsetX: {offsetX}, offsetY: {offsetY}), ";
            Actions = Actions.MoveToElement(toElement, offsetX, offsetY);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="toElement">To be added...</param>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        /// <param name="offsetOrigin">To be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement, int offsetX, int offsetY,
            MoveToElementOffsetOrigin offsetOrigin)
        {
            ChainedActions +=
                $"MoveToElement(toElement: {toElement}, offsetX: {offsetX}, offsetY: {offsetY}, offsetOrigin: {offsetOrigin}), ";
            Actions = Actions.MoveToElement(toElement, offsetX, offsetY, offsetOrigin);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="toElement">To be added...</param>
        /// <param name="toElementPoint">To be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement, ElementPoint toElementPoint)
        {
            return MoveTo(toElement.Location().Point(toElementPoint));
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="x">To be added...</param>
        /// <param name="y">To be added...</param>
        public ExtendedActions MoveTo(int x, int y)
        {
            ChainedActions += $"MoveTo(x: {x}, y: {y}), ";
            Actions = Actions.MoveToElement(Driver.Body(), x, y);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="point">To be added...</param>
        public ExtendedActions MoveTo(Point point)
        {
            return MoveTo(point.X, point.Y);
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        public ExtendedActions MoveByOffset(int offsetX, int offsetY)
        {
            ChainedActions += $"MoveByOffset(offsetX: {offsetX}, offsetY: {offsetY}), ";
            Actions = Actions.MoveByOffset(offsetX, offsetY);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="onElement">To be added...</param>
        public ExtendedActions ContextClick(IWebElement onElement)
        {
            ChainedActions += $"ContextClick(onElement: {onElement}), ";
            Actions = Actions.ContextClick(onElement);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="">To be added...</param>
        public ExtendedActions ContextClick()
        {
            ChainedActions += "ContextClick(), ";
            Actions = Actions.ContextClick();
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="source">To be added...</param>
        /// <param name="target">To be added...</param>
        public ExtendedActions DragAndDrop(IWebElement source, IWebElement target)
        {
            ChainedActions += $"DragAndDrop(source: {source}, target: {target}), ";
            Actions = Actions.DragAndDrop(source, target);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="source">To be added...</param>
        /// <param name="offsetX">To be added...</param>
        /// <param name="offsetY">To be added...</param>
        public ExtendedActions DragAndDropToOffset(IWebElement source, int offsetX, int offsetY)
        {
            ChainedActions += $"DragAndDropToOffset(source: {source}, offsetX: {offsetX}, offsetY: {offsetY}), ";
            Actions = Actions.DragAndDropToOffset(source, offsetX, offsetY);
            return this;
        }

        /// <summary>
 ///To be added...</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void BuildAndPerform(Logger logger = null)
        {
            ChainedActions = ChainedActions.Trim().Trim(',');

            logger?.Information($"Building and attempting to execute a {{ {ChainedActions} }} chain of actions.");

            Actions.Build().Perform();

            logger?.Information("Execution of actions was successful!");
        }

        /// <summary>
 ///Performs this action on the browser, and then waits until the condition is met.</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">The <see cref="Func" />, that defines the condition until the browser must wait.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public void BuildAndPerform<T>(WebDriverWait wait, Func<IWebDriver, T> condition, Logger logger = null)
        {
            BuildAndPerform(logger);

            logger?.Information("Waiting until a condition.");

            wait.Until(condition);

            logger?.Information("Wait is finished, condition is met!");
        }
    }
}