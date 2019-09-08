using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;

namespace ClassLibrary
{

    public class BasePageObject : IPageObject
    {

        public BasePageObject(ISearchContext searchContext)
        {
            SearchContext = searchContext;


        }

        public BasePageObject(IWebDriver driver)
        {
            SearchContext = driver;


        }

        public BasePageObject(IWebElement element)
        {
            SearchContext = element;


        }















        public ISearchContext SearchContext { get; }





    }
}
