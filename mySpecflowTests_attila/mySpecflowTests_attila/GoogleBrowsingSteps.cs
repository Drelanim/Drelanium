﻿using System;
using System.ComponentModel;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;


namespace mySpecflowTests_attila
{


    [Binding]
    public class GoogleBrowsingSteps
    {

        [Given(@"Google is launched on url (.*)")]
        public void GivenGoogleIsLaunchedOnUrl(string url)
        {

            IWebDriver webdriver = new ChromeDriver();
            // IWebDriver webdriver = new InternetExplorerDriver(@"C:\seleniumDrivers");
            webdriver.Navigate().GoToUrl(url);
            Thread.Sleep(3000);
            webdriver.Quit();

            }

      


        

    }
}






