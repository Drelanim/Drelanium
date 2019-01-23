using OpenQA.Selenium;
using System;
using System.Linq;

namespace PFW.SchrodersCom.TA.BaseClasses
{
    public class BasePage
    {
        public IWebDriver Driver { get; set; }

        public string PageUrl { get; set; }

        public BasePage(IWebDriver driver) => Driver = driver;



        public IWebElement FindWebElementByName(string name)
        {
            return Driver.FindElement(By.Name(name));
        }

        public IWebElement FindWebElementById(string id)
        {
            return Driver.FindElement(By.Id(id));
        }

        public IWebElement FindWebElementByCSSSelector(string cssSelector)
        {
            return Driver.FindElement(By.CssSelector(cssSelector));
        }

        public IWebElement FindWebElementByXPath(string xPath)
        {
            return Driver.FindElement(By.XPath(xPath));
        }


        public string GetWebElementAttribute(IWebElement webElement, string attributeName)
        {
            return webElement.GetAttribute(attributeName);
        }

        public string[] GetWebElementClasses(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "class").Split(' ').Select(x => x.Trim()).ToArray();
        }

        public string[] GetWebElementStyles(IWebElement webElement)
        {
            return GetWebElementAttribute(webElement, "style").Split(';').Select(x => x.Trim()).ToArray();
        }


    }
}
