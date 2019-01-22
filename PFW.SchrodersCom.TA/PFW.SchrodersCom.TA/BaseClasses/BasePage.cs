using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFW.SchrodersCom.TA.BaseClasses
{
    public abstract class BasePage
    {

        public RemoteWebDriver Driver { get; set; }

        public string PageUrl { get; set; }

        public BasePage(RemoteWebDriver driver) : base() => Driver = driver;


      



    }
}
