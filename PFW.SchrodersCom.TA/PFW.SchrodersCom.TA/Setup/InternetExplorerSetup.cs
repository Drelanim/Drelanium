using OpenQA.Selenium.IE;

namespace PFW.SchrodersCom.TA.Setup
{
    public static class InternetExplorerSetup
    {
        public static InternetExplorerOptions CreateOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IgnoreZoomLevel = true;
            return options;
        }

    }
}
