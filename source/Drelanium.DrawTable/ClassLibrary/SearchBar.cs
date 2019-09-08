using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace ClassLibrary
{
    public class SearchBar : BasePageWidget
    {
        public SearchBar(IWebElement element) : base(element)
        {
            
            

        }



        public IWebElement Item => this.FindElement(By.Name("q"));


    }
}
