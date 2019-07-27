using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace PFW.SchrodersCom.TA.Bases.Support
{
    public static class WebElementActions
    {




        public static IWebElement FindWebElementByName(RemoteWebDriver driver, string name)
        {
            return driver.FindElement(By.Name(name));
        }

        public static IWebElement FindWebElementById(RemoteWebDriver driver, string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public static IWebElement FindWebElementByCSSSelector(RemoteWebDriver driver, string cssSelector)
        {
            return driver.FindElement(By.CssSelector(cssSelector));
        }

        public static IWebElement FindWebElementByXPath(RemoteWebDriver driver, string xPath)
        {
            return driver.FindElement(By.XPath(xPath));
        }




        public static string GetWebElementAttribute(IWebElement webElement, string attributeName)
        {
            return webElement.GetAttribute(attributeName);
        }

        public static string[] GetWebElementClasses(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "class").Split(' ').Select(x => x.Trim()).ToArray();
        }

        public static string[] GetWebElementStyles(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "style").Split(';').Select(x => x.Trim()).ToArray();
        }

        public static string GetWebElementInnerText(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "innerText");
        }
        public static string GetWebElementValue(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "value");
        }








    }
}
