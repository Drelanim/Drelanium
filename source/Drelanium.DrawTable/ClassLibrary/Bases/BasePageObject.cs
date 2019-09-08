using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;

namespace ClassLibrary
{
    public class BasePageObject : IPageObject
    {
     
        public BasePageObject(IWebDriver driver)
        {
            Driver = driver;
        }


        public IWebDriver Driver { get; }


        public IWebElement FindElement(By by)
        {
          return  Driver.FindElement(by);

        }






        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Driver.FindElements(by);
        }
    }
}
