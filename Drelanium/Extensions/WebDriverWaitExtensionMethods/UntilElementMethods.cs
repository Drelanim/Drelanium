using System;
using Drelanium.Lists;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    public static class UntilElementMethods
    {

        /// <param name="element">The element.</param>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, IWebElement element)
        {
            wait.Message += $"Waited until ({element}) element is displayed";
            return wait.Until(driver => element.Displayed);
        }

        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.Message += $"Waited until element located by ({locator}) is displayed";
            return wait.Until(driver => searchContext.FindElement(locator).Displayed);
        }

        /// <param name="element">The element.</param>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, IWebElement element)
        {
            wait.Message += $"Waited until ({element}) element is not displayed";
            return wait.Until(driver => !element.Displayed);
        }

        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsNotDisplayed(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.Message += $"Waited until element located by ({locator}) is not displayed";
            return wait.Until(driver => !searchContext.FindElement(locator).Displayed);
        }

        /// <param name="element">The element.</param>
        public static bool UntilElementIsEnabled(this WebDriverWait wait, IWebElement element)
        {
            wait.Message += $"Waited until ({element}) element is enabled";
            return wait.Until(driver => element.Enabled);
        }

        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsEnabled(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.Message += $"Waited until element located by ({locator}) is enabled";
            return wait.Until(driver => searchContext.FindElement(locator).Enabled);
        }

        /// <param name="element">The element.</param>
        public static bool UntilElementIsNotEnabled(this WebDriverWait wait, IWebElement element)
        {
            wait.Message += $"Waited until ({element}) element is not enabled";
            return wait.Until(driver => !element.Enabled);
        }

        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementIsNotEnabled(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.Message += $"Waited until element located by ({locator}) is not enabled";
            return wait.Until(driver => !searchContext.FindElement(locator).Enabled);
        }

        /// <param name="condition">The condition, that the driver is waiting for.</param>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="element">The element.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, IWebElement element, string attributeName, Func<string, bool> condition)
        {
            wait.Message += $"Waited until ({element}) element's ({attributeName}) attribute to be changed according to condition";
            return wait.Until(driver => condition(element.GetAttribute(attributeName)));
        }

        /// <param name="condition">The condition, that the driver is waiting for.</param>
        /// <param name="element">The element.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, IWebElement element, ElementAttributeName webElementAttributeName, Func<string, bool> condition)
        {
            return wait.UntilElementAttribute(element, webElementAttributeName.AttributeName, condition);
        }

        /// <param name="condition">The condition, that the driver is waiting for.</param>
        /// <param name="attributeName">Name of the attribute of the element.</param>
        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, ISearchContext searchContext, By locator, string attributeName, Func<string, bool> condition)
        {
            wait.Message += $"Waited until element located by ({locator}) ({attributeName}) attribute to be changed according to condition";
            return wait.Until(driver => condition(searchContext.FindElement(locator).GetAttribute(attributeName)));
        }

        /// <param name="condition">The condition, that the driver is waiting for.</param>
        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static bool UntilElementAttribute(this WebDriverWait wait, ISearchContext searchContext, By locator, ElementAttributeName webElementAttributeName, Func<string, bool> condition)
        {
            return wait.UntilElementAttribute(searchContext, locator, webElementAttributeName.AttributeName, condition);
        }

        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static IWebElement UntilElementExists(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.Message += $"Waited until element located by ({locator}) exists";
            return wait.Until(driver => searchContext.FindElement(locator));
        }

        /// <param name="searchContext">The context used to search element.</param>
        /// <param name="locator">The locating mechanism to use.</param>
        public static void UntilElementDisappears(this WebDriverWait wait, ISearchContext searchContext, By locator)
        {
            wait.Message += $"Waited until element located by ({locator}) disappears";
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
        }

    }

}