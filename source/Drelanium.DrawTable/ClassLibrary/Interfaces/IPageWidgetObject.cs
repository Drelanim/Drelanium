using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
  public  interface IPageWidgetObject : IPageObject
    {



         IWebElement WrappedElement { get;  }





    }
}
