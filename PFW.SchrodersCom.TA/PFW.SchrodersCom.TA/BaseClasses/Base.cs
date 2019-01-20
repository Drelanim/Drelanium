using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PFW.SchrodersCom.TA.BaseClasses
{
    public abstract class Base
    {

        public string CurrentPageKey { get; }
        public BasePage CurrentPage { get; set; }

        public IWebDriver Driver { get; set; }

        public Base()
        {
            CurrentPageKey = "CurrentPageKey";
        }




    }
}
