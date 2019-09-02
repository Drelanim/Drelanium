using System;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;

namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class ExtendedActions
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ExtendedActions(IWebDriver driver)
        {
            Driver = driver;
            Actions = new Actions(driver);
        }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>

        private IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="OpenQA.Selenium.Interactions.Actions" />
        /// </summary>

        private Actions Actions { get; set; }


        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private string ChainedActions { get; set; }


        /// <summary>
        ///     ...Description to be added...
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void BuildAndPerform(Logger logger = null)
        {
            ChainedActions = ChainedActions.Trim().Trim(',');

            logger?.Information($"Building and attempting to execute a {{ {ChainedActions} }} chain of actions.");

            Actions.Build().Perform();

            logger?.Information("Execution of actions was successful!");
        }

        /// <summary>
        ///     Performs this action on the browser, and then waits until the condition is met.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public void BuildAndPerform<T>(WebDriverWait wait, Func<IWebDriver, T> condition, Logger logger = null)
        {
            BuildAndPerform(logger);

            logger?.Information("Waiting until a condition.");

            wait.Until(condition);

            logger?.Information("Wait is finished, condition is met!");
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="onElement">...Description to be added...</param>
        public ExtendedActions Click(IWebElement onElement)
        {
            ChainedActions += $"Click(onElement: {onElement}), ";
            Actions = Actions.Click(onElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="onElement">...Description to be added...</param>
        /// <param name="elementPoint">...Description to be added...</param>
        public ExtendedActions Click(IWebElement onElement, ElementPoint elementPoint)
        {
            MoveToElement(onElement, elementPoint);
            Click(onElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ExtendedActions Click()
        {
            ChainedActions += "Click(), ";
            Actions = Actions.Click();
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="onElement">...Description to be added...</param>
        public ExtendedActions ClickAndHold(IWebElement onElement)
        {
            ChainedActions += $"ClickAndHold(onElement: {onElement}), ";
            Actions = Actions.ClickAndHold(onElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ExtendedActions ClickAndHold()
        {
            ChainedActions += "ClickAndHold(), ";
            Actions = Actions.ClickAndHold();
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="onElement">...Description to be added...</param>
        public ExtendedActions ContextClick(IWebElement onElement)
        {
            ChainedActions += $"ContextClick(onElement: {onElement}), ";
            Actions = Actions.ContextClick(onElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ExtendedActions ContextClick()
        {
            ChainedActions += "ContextClick(), ";
            Actions = Actions.ContextClick();
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="onElement">
        ///     ...Description to be added...
        /// </param>
        public ExtendedActions DoubleClick(IWebElement onElement)
        {
            ChainedActions += $"DoubleClick(onElement: {onElement}), ";
            Actions = Actions.DoubleClick(onElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ExtendedActions DoubleClick()
        {
            ChainedActions += "DoubleClick(), ";
            Actions = Actions.DoubleClick();
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="source">...Description to be added...</param>
        /// <param name="target">...Description to be added...</param>
        public ExtendedActions DragAndDrop(IWebElement source, IWebElement target)
        {
            ChainedActions += $"DragAndDrop(source: {source}, target: {target}), ";
            Actions = Actions.DragAndDrop(source, target);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="source">...Description to be added...</param>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        public ExtendedActions DragAndDropToOffset(IWebElement source, int offsetX, int offsetY)
        {
            ChainedActions += $"DragAndDropToOffset(source: {source}, offsetX: {offsetX}, offsetY: {offsetY}), ";
            Actions = Actions.DragAndDropToOffset(source, offsetX, offsetY);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="theKey">...Description to be added...</param>
        public ExtendedActions KeyDown(string theKey)
        {
            ChainedActions += $"KeyDown(theKey: \"{theKey}\"), ";
            Actions = Actions.KeyDown(theKey);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">...Description to be added...</param>
        /// <param name="theKey">...Description to be added...</param>
        public ExtendedActions KeyDown(IWebElement element, string theKey)
        {
            ChainedActions += $"KeyDown(element: {element}, theKey: \"{theKey}\"";
            Actions = Actions.KeyDown(element, theKey);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="theKey">...Description to be added...</param>
        public ExtendedActions KeyUp(string theKey)
        {
            ChainedActions += $"KeyDown(theKey: \"{theKey}\"), ";
            Actions = Actions.KeyUp(theKey);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">...Description to be added...</param>
        /// <param name="theKey">...Description to be added...</param>
        public ExtendedActions KeyUp(IWebElement element, string theKey)
        {
            ChainedActions += $"KeyUp(element: {element}, theKey: \"{theKey}\"), ";
            Actions = Actions.KeyUp(element, theKey);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        public ExtendedActions MoveByOffset(int offsetX, int offsetY)
        {
            ChainedActions += $"MoveByOffset(offsetX: {offsetX}, offsetY: {offsetY}), ";
            Actions = Actions.MoveByOffset(offsetX, offsetY);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="x">...Description to be added...</param>
        /// <param name="y">...Description to be added...</param>
        public ExtendedActions MoveTo(int x, int y)
        {
            ChainedActions += $"MoveTo(x: {x}, y: {y}), ";
            Actions = Actions.MoveToElement(Driver.Body(), x, y);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="point">...Description to be added...</param>
        public ExtendedActions MoveTo(Point point)
        {
            return MoveTo(point.X, point.Y);
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="toElement">
        ///     ...Description to be added...
        /// </param>
        public ExtendedActions MoveToElement(IWebElement toElement)
        {
            ChainedActions += $"MoveToElement(toElement: {toElement}), ";
            Actions = Actions.MoveToElement(toElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="toElement">...Description to be added...</param>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement, int offsetX, int offsetY)
        {
            ChainedActions += $"MoveToElement(toElement: {toElement}, offsetX: {offsetX}, offsetY: {offsetY}), ";
            Actions = Actions.MoveToElement(toElement, offsetX, offsetY);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="toElement">...Description to be added...</param>
        /// <param name="offsetX">...Description to be added...</param>
        /// <param name="offsetY">...Description to be added...</param>
        /// <param name="offsetOrigin">...Description to be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement, int offsetX, int offsetY,
            MoveToElementOffsetOrigin offsetOrigin)
        {
            ChainedActions +=
                $"MoveToElement(toElement: {toElement}, offsetX: {offsetX}, offsetY: {offsetY}, offsetOrigin: {offsetOrigin}), ";
            Actions = Actions.MoveToElement(toElement, offsetX, offsetY, offsetOrigin);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="toElement">...Description to be added...</param>
        /// <param name="toElementPoint">...Description to be added...</param>
        public ExtendedActions MoveToElement(IWebElement toElement, ElementPoint toElementPoint)
        {
            return MoveTo(toElement.Location().Point(toElementPoint));
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="onElement">...Description to be added...</param>
        public ExtendedActions Release(IWebElement onElement)
        {
            ChainedActions += $"Release(onElement: {onElement}), ";
            Actions = Actions.Release(onElement);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public ExtendedActions Release()
        {
            ChainedActions += "Release(), ";
            Actions = Actions.Release();
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="keysToSend">...Description to be added...</param>
        public ExtendedActions SendKeys(string keysToSend)
        {
            ChainedActions += $"SendKeys(keysToSend: \"{keysToSend}\"), ";
            Actions = Actions.SendKeys(keysToSend);
            return this;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="element">...Description to be added...</param>
        /// <param name="keysToSend">...Description to be added...</param>
        public ExtendedActions SendKeys(IWebElement element, string keysToSend)
        {
            ChainedActions += $"SendKeys(element: {element}, keysToSend: \"{keysToSend}\"), ";
            Actions = Actions.SendKeys(element, keysToSend);
            return this;
        }
    }
}