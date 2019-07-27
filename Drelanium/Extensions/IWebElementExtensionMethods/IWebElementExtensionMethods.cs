using System;
using System.Text.RegularExpressions;
using Drelanium.Extensions.ISearchContextExtensionMethods;
using Drelanium.WebElement;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



// ReSharper disable InconsistentNaming


namespace Drelanium.Extensions.IWebElementExtensionMethods
{

    public static class IWebElementExtensionMethods
    {

        /// <param name="element">The element.</param>
        public static Attributes Attributes(this IWebElement element)
        {
            return new Attributes(element);
        }

        /// <param name="element">The element.</param>
        public static Properties Properties(this IWebElement element)
        {
            return new Properties(element);
        }

        /// <param name="element">The element.</param>
        public static Style Style(this IWebElement element)
        {
            return new Style(element);
        }



        /// <param name="element">The element.</param>
        public static SelectElement SelectFrom(this IWebElement element)
        {

            return new SelectElement(element);
        }







        /// <param name="element">The element.</param>
        /// <param name="timeout">The timeout value indicating how long to wait for the condition.</param>
        public static void Click(this IWebElement element, TimeSpan timeout)
        {
            element
                .Wait(timeout, $"Waited until ({element}) element is successfully clicked", new[] {typeof(WebDriverException)})
                .Until(webDriver =>
                {
                    element.Click();
                    return true;
                });
        }




        /// <summary>Put focus on the element.</summary>
        /// <param name="element">The element.</param>
        public static void Focus(this IWebElement element)
        {

            element.ExecuteJavaScript("arguments[0].focus(); ", element);



        }





        /// <summary>Loose focus from the element. The body element will get the focus.</summary>
        /// <param name="element">The element.</param>
        public static void Blur(this IWebElement element)
        {

            element.ExecuteJavaScript("arguments[0].blur(); ", element);



        }



        /// <summary>Performs a JavaScript click() on the element.</summary>
        /// <param name="element">The element.</param>
        public static void JSClick(this IWebElement element)
        {

            element.ExecuteJavaScript("arguments[0].click(); ", element);



        }












        /// <param name="element">The element.</param>
        public static string GetWebElementID(this IWebElement element)
        {
            return new Regex("\\d{2,}").Match(element.ToString()).Value;
        }

        /// <summary>Dispatches a HTMLEvent from the global window object on an element.</summary>
        /// <param name="element">The event will be dispatched on this element.</param>
        public static void DispatchEvent(this IWebElement element, string eventName)
        {
            element.ExecuteJavaScript($"arguments[0].dispatchEvent({eventName}); ", element);
        }

    }

}