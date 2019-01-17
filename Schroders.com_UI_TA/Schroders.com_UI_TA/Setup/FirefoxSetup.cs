using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace Schroders.com_UI_TA.Setup
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
