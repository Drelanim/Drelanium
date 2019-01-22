using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace PFW.SchrodersCom.TA.Setup
{
    public class WebDriverSetup
    {

        public TestConfiguration TestConfiguration { get; }

        public WebDriverSetup()
        {
            TestConfiguration = new TestConfiguration();
        }



        public RemoteWebDriver StartWebDriver()
        {
            
            RemoteWebDriver driver;

            switch (TestConfiguration.SelectedBrowser())
            {
                case "CHROME":
                    driver = new ChromeDriver(CreateChromeOptions());
                    break;
                case "FIREFOX":
                    driver = new FirefoxDriver(CreateFirefoxOptions());
                    break;
                case "INTERNETEXPLORER":
                    driver = new InternetExplorerDriver(CreateInternetExplorerOptions());
                    break;
                default:
                    throw new Exception();
            }

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            return driver;
        }


        public ChromeOptions CreateChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();

            switch (TestConfiguration.SelectedHeadlessMode())
            {
                case "ON":
                    options.AddArgument("--headless");
                    break;
                case "OFF":
                    break;
                default:
                    throw new Exception();
            }
            return options;
        }

        public FirefoxOptions CreateFirefoxOptions()
        {
            FirefoxOptions options = new FirefoxOptions();

            switch (TestConfiguration.SelectedHeadlessMode())
            {
                case "ON":
                    options.AddArgument("--headless");
                    break;
                case "OFF":
                    break;
                default:
                    throw new Exception();
            }
            return options;
        }


        public InternetExplorerOptions CreateInternetExplorerOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IgnoreZoomLevel = true;
            return options;
        }






    }
}
