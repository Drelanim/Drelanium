using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using TestCommon;

namespace PlanetWinE2ETests.PageObjects
{
    public class PlanetWin365StartPage : SeleniumPageBase
    {
        // page URL
        private string pageUrl;

        // default constructor when we just want to create page object without navigating and with driver already active 
        public PlanetWin365StartPage(RemoteWebDriver driver) : base(driver)
        {
        }

        // constructor with optional page loading, overloaded per browser type to allow customization
        public PlanetWin365StartPage(FirefoxOptions browserOptions, string url = null)
            : base(browserOptions)
        {
            if (url != null)
            {
                pageUrl = url;
                try
                {
                    Driver.Navigate().GoToUrl(pageUrl);
                }
                catch (Exception e)
                {
                    // ignore navigate exceptions
                }
            }
        }

        public PlanetWin365StartPage(EdgeOptions browserOptions, string url = null)
            : base(browserOptions)
        {
            if (url != null)
            {
                pageUrl = url;
                try
                {
                    Driver.Navigate().GoToUrl(pageUrl);
                }
                catch (Exception e)
                {
                    // ignore navigate exceptions
                }
            }
        }
        public PlanetWin365StartPage(ChromeOptions browserOptions, string url = null)
            : base(browserOptions)
        {
            if (url != null)
            {
                pageUrl = url;
                try
                {
                    Driver.Navigate().GoToUrl(pageUrl);
                }
                catch (Exception e)
                {
                    // ignore navigate exceptions
                }
            }
        }
        public PlanetWin365StartPage(InternetExplorerOptions browserOptions, string url = null)
            : base(browserOptions)
        {
            if (url != null)
            {
                pageUrl = url;
                try
                {
                    Driver.Navigate().GoToUrl(pageUrl);
                }
                catch (Exception e)
                {
                    // ignore navigate exceptions
                }
            }
        }

        // page elements used for login
        //a[@title='Italiano']
        // the XPAT is dynamically constructed with language string...
        public By italianImageBtn;
        //*[@id="h_w_cLogin_ctrlLogin_Username"]
        public By usernameField = By.XPath("//*[@id=\"h_w_cLogin_ctrlLogin_Username\"]");
        //*[@id="h_w_cLogin_ctrlLogin_Password"]
        public By passwordField = By.XPath("//*[@id=\"h_w_cLogin_ctrlLogin_Password\"]");
        //*[@id="h_w_cLogin_ctrlLogin_lnkBtnLogin"]
        public By enterBtn = By.XPath("//*[@id=\"h_w_cLogin_ctrlLogin_lnkBtnLogin\"]");
 
  

        // public method login
        public void Login(string username = "EPAM_QA_BUD_21", string password = "Arpito", string language = "Italiano")
        {
            try
            {
                // wait for menus to load fully
                //WaitForAjax();

                // click on language button
                italianImageBtn = By.XPath($"//a[@title=\"{language}\"]");
                this.ClickWidget(italianImageBtn);

                // find username field and fill it
                this.LocateWidget(usernameField).SendKeys(username);

                // find password field and fill it
                this.LocateWidget(passwordField).SendKeys(password);

                // press enter button to login
                this.ClickWidget(enterBtn);

                // this takes place in THEN STEP
                // verify logged in condition
                // LogObj.Log("verify logged in condition");
                // this.LocateWidget(logoutBtn);
            }
            catch (Exception e)
            {
                Assert.Fail($"widget error in PlanetWin login - {e.Message}");
            }
        }
    }
}
