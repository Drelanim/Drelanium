using System;
using System.IO;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Drelanium;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {


        public Func<IWebDriver> SSSS()
        {





        }











        [Fact]
        public void Test1()
        {


            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigation().GoToUrl(new Uri("https://www.google.com"), true, true, 30,
                uri => uri.GetLeftPart(UriPartial.Authority) == "https://www.google.com");


            driver.Wait(30, sleepIntervalInSeconds: 1, clock: null).Until(webdriver =>
            {
                webdriver.FindElement(By.Name("q")).SendKeys("1");
                return false;
            });




            driver.Quit();



        }
    }
}
