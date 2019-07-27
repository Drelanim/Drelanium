using OpenQA.Selenium;
using OpenQA.Selenium.Remote;


namespace Drelanium.WebDriver
{

    public class Capabilities : ICapabilities
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Capabilities(IWebDriver driver)
        {
            Driver = driver;
            CapabilitiesImplementation = ((RemoteWebDriver) driver).Capabilities;
        }

        private ICapabilities CapabilitiesImplementation { get; }
        private IWebDriver Driver { get; }
        public string BrowserName => HasCapability("browserName") ? GetCapability("browserName").ToString() : null;
        public string Version => HasCapability("version") ? GetCapability("version").ToString() : null;
        public string Platform => HasCapability("platform") ? GetCapability("platform").ToString() : null;
        public string HandlesAlerts => HasCapability("handlesAlerts") ? GetCapability("handlesAlerts").ToString().ToLower() : null;
        public string CssSelectorsEnabled => HasCapability("cssSelectorsEnabled") ? GetCapability("cssSelectorsEnabled").ToString().ToLower() : null;
        public string JavascriptEnabled => HasCapability("javascriptEnabled") ? GetCapability("javascriptEnabled").ToString().ToLower() : null;
        public string DatabaseEnabled => HasCapability("databaseEnabled") ? GetCapability("databaseEnabled").ToString().ToLower() : null;
        public string LocationContextEnabled => HasCapability("locationContextEnabled") ? GetCapability("locationContextEnabled").ToString().ToLower() : null;
        public string ApplicationCacheEnabled => HasCapability("applicationCacheEnabled") ? GetCapability("applicationCacheEnabled").ToString().ToLower() : null;
        public string BrowserConnectionEnabled => HasCapability("browserConnectionEnabled") ? GetCapability("browserConnectionEnabled").ToString().ToLower() : null;
        private string WebStorageEnabled => HasCapability("webStorageEnabled") ? GetCapability("webStorageEnabled").ToString().ToLower() : null;
        public string AcceptSslCerts => HasCapability("acceptSslCerts") ? GetCapability("acceptSslCerts").ToString().ToLower() : null;
        public string Rotatable => HasCapability("rotatable") ? GetCapability("rotatable").ToString().ToLower() : null;
        public string NativeEvents => HasCapability("nativeEvents") ? GetCapability("nativeEvents").ToString().ToLower() : null;
        public string Proxy => HasCapability("proxy") ? GetCapability("proxy").ToString() : null;
        public string UnexpectedAlertBehaviour => HasCapability("unexpectedAlertBehaviour") ? GetCapability("unexpectedAlertBehaviour").ToString() : null;
        public string ElementScrollBehavior => HasCapability("elementScrollBehavior") ? GetCapability("elementScrollBehavior").ToString() : null;
        public string WebdriverRemoteSessionid => HasCapability("webdriver.remote.sessionid") ? GetCapability("webdriver.remote.sessionid").ToString() : null;
        public string WebdriverRemoteQuietExceptions => HasCapability("webdriver.remote.quietExceptions") ? GetCapability("webdriver.remote.quietExceptions").ToString().ToLower() : null;
        public string Path => HasCapability("path") ? GetCapability("path").ToString() : null;
        public string SeleniumProtocol => HasCapability("seleniumProtocol") ? GetCapability("seleniumProtocol").ToString() : null;
        public string MaxInstances => HasCapability("maxInstances") ? GetCapability("maxInstances").ToString() : null;
        public string Environment => HasCapability("environment") ? GetCapability("environment").ToString() : null;

        public bool HasCapability(string capability)
        {
            return CapabilitiesImplementation.HasCapability(capability);
        }

        public object GetCapability(string capability)
        {
            return CapabilitiesImplementation.GetCapability(capability);
        }

        public object this[string capabilityName] => CapabilitiesImplementation[capabilityName];

        public override string ToString()
        {
            return CapabilitiesImplementation.ToString();
        }

    }

}