// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo

namespace Drelanium.WebDriverConfiguration
{

    public enum BrowserType
    {

        CHROME,

        FIREFOX,

        INTERNETEXPLROER

    }

    public enum TestMode
    {

        LOCAL,

        REMOTE

    }

    public enum HeadlessMode
    {

        ON,

        OFF

    }

    public class DriverConfiguration
    {

        public BrowserType BrowserType { get; set; }
        public TestMode TestMode { get; set; }
        public HeadlessMode HeadlessMode { get; set; }
        public string[] DriverOptionsArguments { get; set; }
        public string SeleniumGridHubUrl { get; set; }

    }

}