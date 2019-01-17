using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Schroders.com_UI_TA.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;




namespace Schroders.com_UI_TA.Pages
{
    class GlobalHomePage : BasePage
    {
        private string _urlPath = "";
        private PageTypes _pageType = PageTypes.GlobalHome;

        public GlobalHomePage(TestEnvironment environment): base(environment)
        {
            this.PageType = _pageType;
            this.UrlPath = _urlPath;
        }



        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }







    }
}
