using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using TestCommon;

namespace PlanetWinE2ETests.PageObjects
{
    class PlanetWin365UserDetailsPage : SeleniumPageBase
    {
        // page URL
        private string pageUrl;

        // default constructor when we just want to create page object without navigating and with driver already active 
        public PlanetWin365UserDetailsPage(RemoteWebDriver driver) : base(driver)
        {
        }

        // constructor with optional page loading, overloaded per browser type to allow customization
        public PlanetWin365UserDetailsPage(FirefoxOptions browserOptions, string url = null)
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

        public PlanetWin365UserDetailsPage(EdgeOptions browserOptions, string url = null)
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
        public PlanetWin365UserDetailsPage(ChromeOptions browserOptions, string url = null)
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
        public PlanetWin365UserDetailsPage(InternetExplorerOptions browserOptions, string url = null)
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
        // page elements
        //*[@id="divHeader"]/div[2]/div[1]/ul/li[6]/a"
        public By accountTab = By.XPath("//*[@id=\"s_w_PC_PC_LnkDatiOverview\"]");
        //*[@id="s_w_PC_PC_Username"]
        public By usernameField = By.XPath("//*[@id=\"s_w_PC_PC_Username\"]");
        //*[@id="s_w_PC_PC_lnkDatiPassword"]
        public By passwordTab = By.XPath("//*[@id=\"s_w_PC_PC_lnkDatiPassword\"]");
        //*[@id="s_w_PC_PC_btnUpdatePwd"]
        public By passwordTabSaveButton = By.XPath("//*[@id=\"s_w_PC_PC_btnUpdatePwd\"]");
        //*[@id="s_w_PC_PC_btnResetPwd"]
        public By resetBtn = By.XPath("//*[@id=\"s_w_PC_PC_btnResetPwd\"]");
        //*[@id="s_w_PC_PC_CurrentPassword"]
        public By passwordTabCurrentPasswordInput = By.XPath("//*[@id=\"s_w_PC_PC_CurrentPassword\"]");
        //*[@id="s_w_PC_PC_Password"]
        public By passwordTabNewPasswordInput = By.XPath("//*[@id=\"s_w_PC_PC_Password\"]");
        //*[@id="s_w_PC_PC_Confirm"]
        public By passwordTabNewPasswordConfirmInput = By.XPath("//*[@id=\"s_w_PC_PC_Confirm\"]");
        //*[@id="s_w_PC_PC_vsValPwdServer"]/ul/li
        public By passwordTabRejectText = By.XPath("//*[@id=\"s_w_PC_PC_vsValPwdServer\"]/ul/li");
        //*[@id="s_w_PC_PC_Msg1_lblResponse"]
        public By passwordChangeSuccessfulText = By.XPath("//*[@id=\"s_w_PC_PC_Msg1_lblResponse\"]");
        //*[@id="s_w_cLogin_lnkBtnLogout"]
        public By logoutBtn = By.XPath("//*[@id=\"s_w_cLogin_lnkBtnLogout\"]");


        // public page comon methods here

    }
}
