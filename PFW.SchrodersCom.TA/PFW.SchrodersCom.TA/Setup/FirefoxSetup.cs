using OpenQA.Selenium.Firefox;

namespace PFW.SchrodersCom.TA.Setup
{
    public static class FirefoxSetup
    {
        public static FirefoxOptions CreateOptions()
        {
            FirefoxOptions options = new FirefoxOptions();
            //    options.AddArguments("--headless");
            return options;
        }

    }
}
