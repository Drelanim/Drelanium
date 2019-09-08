using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
  public static  class StaticClass
    {

        public static IWebElement FindElement(this ISearchContext context ,By by, int index)
        {
            return context.FindElements(by)[index];

        }






    }
}
