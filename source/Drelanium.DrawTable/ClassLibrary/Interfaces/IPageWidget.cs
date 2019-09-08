using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
  public  interface IPageWidget : IPageObject
    {



         IWebElement WrappedElement { get;  }





    }
}
