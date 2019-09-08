﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace ClassLibrary
{


    public class BasePage : BasePageObject, IPage
    {
        public BasePage(IWebDriver driver, Uri url) : base(driver)
        {
            Url = url;
        }

        public Uri Url {get;}





    }
}