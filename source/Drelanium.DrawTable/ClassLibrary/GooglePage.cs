using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary
{
    public class GooglePage : BasePage
    {


        public GooglePage(IWebDriver driver) :base(driver)
        {
        }


        public IWebElement Logo => FindElement(By.Id("hplogo"));


        public SearchBar SearchBar => new SearchBar(this.FindElement(By.ClassName("RNNXgb")));




    }
}
