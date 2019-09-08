using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
  public  interface IPageObject : ISearchContext
    {

         IWebDriver Driver { get;  }





    }
}
