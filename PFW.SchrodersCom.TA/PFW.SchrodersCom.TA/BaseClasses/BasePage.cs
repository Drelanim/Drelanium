using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFW.SchrodersCom.TA.BaseClasses
{
    public abstract class BasePage : Base
    {

        public string PageUrl { get; set; }

        public BasePage(IWebDriver driver) : base()
        {
            PageFactory.InitElements(driver, this);
        }
  
                     






    }
}
