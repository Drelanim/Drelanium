using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
namespace ClassLibrary
{
    public class GooglePage : BasePageObject
    {


        public GooglePage(IWebDriver driver) :base(driver)
        {
        }


        public IWebElement Logo => FindElement(By.Id("hplogo"));


        public IWebElement Logo2 => this.FindElement(By.Id("hplogo"),0);



    }
}
