using System;
using Drelanium.Lists;
using Drelanium.WaitConditions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;
using Serilog.Events;


// ReSharper disable CommentTypo

namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>
    ///     Extension methods for <see cref="WebDriverWait" /> types.
    /// </summary>
    public static class UntilElementMethods
    {
        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has met the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElement<TResult>(this WebDriverWait wait, IWebElement element,
            Func<IWebElement, TResult> condition, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to meet the given condition.");

            var result = wait.Until(WebDriverWaitConditions.Element(element, condition));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, IWebElement element,
            string attributeName, Func<string, TResult> condition, Logger logger = null)
        {
            logger?.Information(
                $"Waiting for ({element}) element's ({attributeName}) attribute to be changed according to condition.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element's ({attributeName}) attribute to be changed according to condition";

            var result = wait.Until(WebDriverWaitCondition.ElementAttribute(element, attributeName, condition));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="webElementAttributeName">...Description to be added...</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        /// <exception cref="WebDriverTimeoutException"></exception>
        /// <exception cref="WebDriverException"></exception>
        /// <exception cref="StaleElementReferenceException"></exception>
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, IWebElement element,
            ElementAttributeName webElementAttributeName, Func<string, TResult> condition, Logger logger = null)
        {
            return wait.UntilElementAttribute(element, webElementAttributeName.AttributeName, condition, logger);
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, ISearchContext searchContext,
            By locator, string attributeName, Func<string, TResult> condition, Logger logger = null)
        {
            logger?.Information(
                $"Waiting for ({locator}) element's ({attributeName}) attribute to be changed according to condition.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) ({attributeName}) attribute to be changed according to condition";

            var result =
                wait.Until(WebDriverWaitCondition.ElementAttribute(searchContext, locator, attributeName, condition));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" />'s given attribute has met the given condition.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="webElementAttributeName">...Description to be added...</param>
        /// <param name="condition">
        ///     The <see cref="Func{T,TResult}" />, that defines the condition until the browser must
        ///     wait.
        /// </param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static TResult UntilElementAttribute<TResult>(this WebDriverWait wait, ISearchContext searchContext,
            By locator,
            ElementAttributeName webElementAttributeName, Func<string, TResult> condition,
            Logger logger = null)
        {
            return wait.UntilElementAttribute(searchContext, locator, webElementAttributeName.AttributeName, condition,
                logger);
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> is not displayed or does not exist anymore.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void UntilElementDisappears(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to disappear.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) disappears";

            wait.Until(driver =>
            {
                try
                {
                    return !searchContext.FindElement(locator).Displayed;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
            });

            logger?.Information("Wait is finished, condition is met!");
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> does not exist anymore.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static IWebElement UntilElementExists(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to exists.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) exists";

            var result = wait.Until(driver => searchContext.FindElement(locator));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        public static bool UntilElementIsClickable(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become clickable.");

            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is clickable";

            var result = wait.Until(driver => element.Displayed && element.Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        public static bool UntilElementIsClickable(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become displayed.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become displayed.");

            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is displayed";

            var result = wait.Until(driver => element.Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become displayed.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become displayed.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) is displayed";

            var result = wait.Until(driver => searchContext.FindElement(locator).Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become enabled.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsEnabled(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become enabled.");

            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is enabled";

            var result = wait.Until(driver => element.Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become displayed.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static bool UntilElementIsEnabled(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become not displayed.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) is enabled";

            var result = wait.Until(driver => searchContext.FindElement(locator).Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        public static bool UntilElementIsNotClickable(this WebDriverWait wait, IWebElement element,
            Logger logger = null)
        {
        }


        public static bool UntilElementIsNotClickable(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not displayed.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, IWebElement element,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become not displayed.");

            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is not displayed";

            var result = wait.Until(driver => !element.Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not displayed.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become not displayed.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) is not displayed";

            var result = wait.Until(driver => !searchContext.FindElement(locator).Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not enabled.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsNotEnabled(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become disabled.");

            wait.Message += $" Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is not enabled";

            var result = wait.Until(driver => !element.Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        /// <summary>
        ///     Waits, until the <see cref="IWebElement" /> has become not enabled.
        ///     <para>Logs the event optionally.</para>
        /// </summary>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">
        ///     <inheritdoc cref="ISearchContext.FindElement(By)" />
        /// </param>
        public static bool UntilElementIsNotEnabled(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become disabled.");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located with ({locator}) is not enabled";

            var result = wait.Until(driver => !searchContext.FindElement(locator).Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }


        public static bool UntilElementIsNotSelected(this WebDriverWait wait, IWebElement element,
            Logger logger = null)
        {
        }


        public static bool UntilElementIsNotSelected(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
        }


        public static bool UntilElementIsSelected(this WebDriverWait wait, IWebElement element,
            Logger logger = null)
        {
        }


        public static bool UntilElementIsSelected(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
        }
    }
}