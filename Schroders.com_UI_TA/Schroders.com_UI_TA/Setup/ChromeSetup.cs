using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Schroders.com_UI_TA.Setup
{
    public static class ChromeSetup
    {
        public static ChromeOptions CreateOptions()
        {
            ChromeOptions options = new ChromeOptions();
        //    options.AddArguments("--headless");
            return options;
        }
                          
    }
}
