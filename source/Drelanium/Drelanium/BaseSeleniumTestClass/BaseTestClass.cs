using System;
using JetBrains.Annotations;
using OpenQA.Selenium;
using Serilog.Core;

namespace Drelanium
{
   public abstract class BaseTestClass
    {

        public abstract IWebDriver Driver { get; set; }

        public abstract IPageObject CurrentPageObject { get; set; }

        public abstract Logger Logger { get; set; }




    }

}
