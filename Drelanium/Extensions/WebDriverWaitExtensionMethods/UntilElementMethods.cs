using System;
using Drelanium.Lists;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;

namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{
    /// <summary>
    /// Extension methods for <see cref="WebDriverWait"/> types.
    ///</summary>
    public static class UntilElementMethods
    {
        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become displayed");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is displayed";
            var result = wait.Until(driver => element.Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become displayed");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) is displayed";
            var result = wait.Until(driver => searchContext.FindElement(locator).Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, IWebElement element,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become not displayed");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is not displayed";
            var result = wait.Until(driver => !element.Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become not displayed");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) is not displayed";
            var result = wait.Until(driver => !searchContext.FindElement(locator).Displayed);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsEnabled(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become enabled");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is enabled";
            var result = wait.Until(driver => element.Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsEnabled(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become not displayed");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) is enabled";
            var result = wait.Until(driver => searchContext.FindElement(locator).Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementIsNotEnabled(this WebDriverWait wait, IWebElement element, Logger logger = null)
        {
            logger?.Information($"Waiting for ({element}) element to become disabled");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element is not enabled";
            var result = wait.Until(driver => !element.Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsNotEnabled(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to become disabled");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) is not enabled";
            var result = wait.Until(driver => !searchContext.FindElement(locator).Enabled);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">The <see cref="Func{TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, IWebElement element, string attributeName,
            Func<string, bool> condition, Logger logger = null)
        {
            logger?.Information(
                $"Waiting for ({element}) element's ({attributeName}) attribute to be changed according to condition");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until ({element}) element's ({attributeName}) attribute to be changed according to condition";
            var result = wait.Until(driver => condition(element.GetAttribute(attributeName)));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="webElementAttributeName">To be added...</param>
        /// <param name="condition">The <see cref="Func{TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="element">The HTMLElement, that is represented by an <see cref="IWebElement" /> instance.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, IWebElement element,
            ElementAttributeName webElementAttributeName, Func<string, bool> condition, Logger logger = null)
        {
            return wait.UntilElementAttribute(element, webElementAttributeName.AttributeName, condition, logger);
        }

        /// <summary>
        ///To be added..
        ///</summary>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="condition">The <see cref="Func{TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, ISearchContext searchContext, By locator,
            string attributeName, Func<string, bool> condition, Logger logger = null)
        {
            logger?.Information(
                $"Waiting for ({locator}) element's ({attributeName}) attribute to be changed according to condition");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) ({attributeName}) attribute to be changed according to condition";
            var result = wait.Until(driver =>
                condition(searchContext.FindElement(locator).GetAttribute(attributeName)));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="webElementAttributeName">To be added...</param>
        /// <param name="condition">The <see cref="Func{TResult}" />, that defines the condition until the browser must wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, ISearchContext searchContext, By locator,
            ElementAttributeName webElementAttributeName, Func<string, bool> condition,
            Logger logger = null)
        {
            return wait.UntilElementAttribute(searchContext, locator, webElementAttributeName.AttributeName, condition,
                logger);
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public static IWebElement UntilElementExists(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to exists");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) exists";
            var result = wait.Until(driver => searchContext.FindElement(locator));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>
        ///To be added...
        ///</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="searchContext">The <see cref="ISearchContext" /> within we search for the element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages (level = Information) during the method exeuction.</param>
        public static void UntilElementDisappears(this WebDriverWait wait, ISearchContext searchContext, By locator,
            Logger logger = null)
        {
            logger?.Information($"Waiting for ({locator}) element to disappear");

            wait.Message +=
                $"Waited ({wait.Timeout.TotalSeconds}) seconds until element located by ({locator}) disappears";
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
    }
}