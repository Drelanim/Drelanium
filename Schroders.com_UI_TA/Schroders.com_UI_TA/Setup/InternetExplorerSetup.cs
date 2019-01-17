using NUnit.Framework;
using OpenQA.Selenium.IE;

namespace Schroders.com_UI_TA.Setup
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
