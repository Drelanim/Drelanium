using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ClassLibrary
{
    public class BasePageWidgetObject : IPageWidgetObject
    {


        public BasePageWidgetObject(IWebElement element)
        {
            WrappedElement = element;
        }



        public IWebElement WrappedElement { get; }

        public IWebDriver Driver => ((RemoteWebElement)WrappedElement).WrappedDriver;




        public IWebElement FindElement(By by)
        {

            return WrappedElement.FindElement(by);

        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return WrappedElement.FindElements(by);
        }
    }
}
