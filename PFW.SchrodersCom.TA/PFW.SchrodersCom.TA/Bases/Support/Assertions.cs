using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace PFW.SchrodersCom.TA.Bases.Support
{
    public static class Assertions
    {



        public static void AssertThatCurrentPageIsLoaded<T>(BaseStep step)
        {
            string urlLoaded = step.Driver.Url;
            string currentPageUrl = CommonSteps.GetCurrentPageUrl<T>(step);
            Assert.AreEqual(urlLoaded, currentPageUrl);
        }

        public static void AssertThatExpectedPageIsLoaded(string expectedUrl, BaseStep step)
        {
            Assert.AreEqual(expectedUrl, step.Driver.Url);
        }


        public static void AssertThatWebElementIsDisplayed(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Displayed);
        }


        public static void AssertThatWebElementIsEnabled(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Enabled);
        }

        public static void AssertThatWebElementIsSelected(IWebElement webElement)
        {
            Assert.IsTrue(webElement.Selected);
        }

        public static void AssertThatWebElementClassesContains(IWebElement webElement, string expectedClass)
        {
            Assert.IsTrue(WebElementActions.GetWebElementClasses(webElement).Contains(expectedClass));
        }

        public static void AssertThatWebElementStylesContains(IWebElement webElement, string expectedStyle)
        {
            Assert.IsTrue(WebElementActions.GetWebElementStyles(webElement).Contains(expectedStyle));
        }

        public static void AssertThatTextboxIsEmpty(IWebElement webElement)
        {
            Assert.IsTrue(String.IsNullOrEmpty(WebElementActions.GetWebElementValue(webElement)));
        }

        public static void AssertThatTextboxIsNotEmpty(IWebElement webElement)
        {
            Assert.IsFalse(String.IsNullOrEmpty(WebElementActions.GetWebElementValue(webElement)));
        }






    }
}
