using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///     Extended implementation of <see cref="ICapabilities" />
    /// </summary>
    public class Capabilities : ICapabilities
    {
        /// <summary>
        ///     <see cref="Capabilities" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Capabilities(IWebDriver driver)
        {
            Driver = driver;
            CapabilitiesImplementation = ((RemoteWebDriver) driver).Capabilities;
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="ICapabilities" />
        private ICapabilities CapabilitiesImplementation { get; }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="IWebDriver" />
        private IWebDriver Driver { get; }

        /// <summary>
        ///     To be added...
        /// </summary>
        public string BrowserName => HasCapability("browserName") ? GetCapability("browserName").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Version => HasCapability("version") ? GetCapability("version").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Platform => HasCapability("platform") ? GetCapability("platform").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string HandlesAlerts =>
            HasCapability("handlesAlerts") ? GetCapability("handlesAlerts").ToString().ToLower() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string CssSelectorsEnabled => HasCapability("cssSelectorsEnabled")
            ? GetCapability("cssSelectorsEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string JavascriptEnabled => HasCapability("javascriptEnabled")
            ? GetCapability("javascriptEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string DatabaseEnabled => HasCapability("databaseEnabled")
            ? GetCapability("databaseEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string LocationContextEnabled => HasCapability("locationContextEnabled")
            ? GetCapability("locationContextEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string ApplicationCacheEnabled => HasCapability("applicationCacheEnabled")
            ? GetCapability("applicationCacheEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string BrowserConnectionEnabled => HasCapability("browserConnectionEnabled")
            ? GetCapability("browserConnectionEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string WebStorageEnabled => HasCapability("webStorageEnabled")
            ? GetCapability("webStorageEnabled").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string AcceptSslCerts => HasCapability("acceptSslCerts")
            ? GetCapability("acceptSslCerts").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Rotatable => HasCapability("rotatable") ? GetCapability("rotatable").ToString().ToLower() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string NativeEvents =>
            HasCapability("nativeEvents") ? GetCapability("nativeEvents").ToString().ToLower() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Proxy => HasCapability("proxy") ? GetCapability("proxy").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string UnexpectedAlertBehaviour => HasCapability("unexpectedAlertBehaviour")
            ? GetCapability("unexpectedAlertBehaviour").ToString()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string ElementScrollBehavior => HasCapability("elementScrollBehavior")
            ? GetCapability("elementScrollBehavior").ToString()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string WebdriverRemoteSessionid => HasCapability("webdriver.remote.sessionid")
            ? GetCapability("webdriver.remote.sessionid").ToString()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string WebdriverRemoteQuietExceptions => HasCapability("webdriver.remote.quietExceptions")
            ? GetCapability("webdriver.remote.quietExceptions").ToString().ToLower()
            : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Path => HasCapability("path") ? GetCapability("path").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string SeleniumProtocol =>
            HasCapability("seleniumProtocol") ? GetCapability("seleniumProtocol").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string MaxInstances => HasCapability("maxInstances") ? GetCapability("maxInstances").ToString() : null;

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Environment => HasCapability("environment") ? GetCapability("environment").ToString() : null;


        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public bool HasCapability(string capability)
        {
            return CapabilitiesImplementation.HasCapability(capability);
        }

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public object GetCapability(string capability)
        {
            return CapabilitiesImplementation.GetCapability(capability);
        }


        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public object this[string capabilityName] => CapabilitiesImplementation[capabilityName];

        /// <summary>
        ///     <inheritdoc></inheritdoc>
        /// </summary>
        public override string ToString()
        {
            return CapabilitiesImplementation.ToString();
        }
    }
}