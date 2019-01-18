using OpenQA.Selenium.Chrome;

namespace PFW.SchrodersCom.TA.Setup
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
