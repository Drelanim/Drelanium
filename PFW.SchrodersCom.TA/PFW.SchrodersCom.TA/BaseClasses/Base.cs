using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
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
        public RemoteWebDriver Driver { get; set; }




        public Base()
        {
            CurrentPageKey = "CurrentPageKey";
        }















    }
}
