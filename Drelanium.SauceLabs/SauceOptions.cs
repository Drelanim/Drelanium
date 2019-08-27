using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;

#pragma warning disable 1591

namespace Drelanium.SauceLabs
{
    /// <summary>
    /// 
    /// </summary>
    public class SauceOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public SauceOptions()
        {
            Options = new Dictionary<string, object>();
        }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, object> Options { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="driverOptions"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddToDriverOptions(DriverOptions driverOptions)
        {
            switch (driverOptions)
            {
                case ChromeOptions chromeOptions:
                {
                    chromeOptions.AddAdditionalCapability("sauce:options", Options, true);
                    break;
                }


                case FirefoxOptions firefoxOptions:
                {
                    firefoxOptions.AddAdditionalCapability("sauce:options", Options, true);
                    break;
                }


                case InternetExplorerOptions internetExplorerOptions:
                {
                    internetExplorerOptions.AddAdditionalCapability("sauce:options", Options, true);
                    break;
                }


                case OperaOptions operaOptions:
                {
                    operaOptions.AddAdditionalCapability("sauce:options", Options, true);
                    break;
                }


                case SafariOptions _:
                {
                    throw new ArgumentException("SauceOptions cannot be added as a capability to a SafariOptions");
                }


                default:
                {
                    throw new ArgumentException("SauceOptions cannot be added as a capability");
                }
            }
        }


        private object GetValue(string key)
        {
            if (!Options.ContainsKey(key))
            {
                Options.Add(key, null);
            }

            return Options[key];
        }


        private void SetValue(string key, object value)
        {
            if (!Options.ContainsKey(key))
            {
                Options.Add(key, null);
            }

            Options[key] = value;
        }


        public object AccessKey
        {
            get => GetValue("accessKey");
            set => SetValue("accessKey", value);
        }


        public object AppiumVersion
        {
            get => GetValue("appiumVersion");
            set => SetValue("appiumVersion", value);
        }


        public object AvoidProxy
        {
            get => GetValue("avoidProxy");
            set => SetValue("avoidProxy", value);
        }


        public object Build
        {
            get => GetValue("build");
            set => SetValue("build", value);
        }


        public object CaptureHtml
        {
            get => GetValue("captureHtml");
            set => SetValue("captureHtml", value);
        }


        public object ChromedriverVersion
        {
            get => GetValue("chromedriverVersion");
            set => SetValue("chromedriverVersion", value);
        }


        public object CrmuxdriverVersion
        {
            get => GetValue("crmuxdriverVersion");
            set => SetValue("crmuxdriverVersion", value);
        }


        public object CustomData
        {
            get => GetValue("customData");
            set => SetValue("customData", value);
        }


        public object DisablePopupHandler
        {
            get => GetValue("disablePopupHandler");
            set => SetValue("disablePopupHandler", value);
        }


        public object ExtendedDebugging
        {
            get => GetValue("extendedDebugging");
            set => SetValue("extendedDebugging", value);
        }


        public object FirefoxAdapterVersion
        {
            get => GetValue("firefoxAdapterVersion");
            set => SetValue("firefoxAdapterVersion", value);
        }


        public object FirefoxProfileUrl
        {
            get => GetValue("firefoxProfileUrl");
            set => SetValue("firefoxProfileUrl", value);
        }


        public object IdleTimeout
        {
            get => GetValue("idleTimeout");
            set => SetValue("idleTimeout", value);
        }


        public object IedriverVersion
        {
            get => GetValue("iedriverVersion");
            set => SetValue("iedriverVersion", value);
        }


        public object MaxDuration
        {
            get => GetValue("maxDuration");
            set => SetValue("maxDuration", value);
        }


        public object Name
        {
            get => GetValue("name");
            set => SetValue("name", value);
        }


        public object ParentTunnel
        {
            get => GetValue("parentTunnel");
            set => SetValue("parentTunnel", value);
        }


        public object Passed
        {
            get => GetValue("passed");
            set => SetValue("passed", value);
        }


        public object Prerun
        {
            get => GetValue("prerun");
            set => SetValue("prerun", value);
        }


        public object PreserveRequeue
        {
            get => GetValue("preserveRequeue");
            set => SetValue("preserveRequeue", value);
        }


        public object Priority
        {
            get => GetValue("priority");
            set => SetValue("priority", value);
        }


        public object ProxyHost
        {
            get => GetValue("proxyHost");
            set => SetValue("proxyHost", value);
        }


        public object Public
        {
            get => GetValue("public");
            set => SetValue("public", value);
        }


        public object RecordLogs
        {
            get => GetValue("recordLogs");
            set => SetValue("recordLogs", value);
        }


        public object RecordScreenshots
        {
            get => GetValue("recordScreenshots");
            set => SetValue("recordScreenshots", value);
        }


        public object RestrictedPublicInfo
        {
            get => GetValue("restrictedPublicInfo");
            set => SetValue("restrictedPublicInfo", value);
        }


        public object ScreenResolution
        {
            get => GetValue("screenResolution");
            set => SetValue("screenResolution", value);
        }


        public object SeleniumVersion
        {
            get => GetValue("seleniumVersion");
            set => SetValue("seleniumVersion", value);
        }


        public object Source
        {
            get => GetValue("source");
            set => SetValue("source", value);
        }


        public object Tags
        {
            get => GetValue("tags");
            set => SetValue("tags", value);
        }


        public object TimeZone
        {
            get => GetValue("timeZone");
            set => SetValue("timeZone", value);
        }


        public object TunnelIdentifier
        {
            get => GetValue("tunnelIdentifier");
            set => SetValue("tunnelIdentifier", value);
        }


        public object Username
        {
            get => GetValue("username");
            set => SetValue("username", value);
        }


        public object VideoUploadOnPass
        {
            get => GetValue("videoUploadOnPass");
            set => SetValue("videoUploadOnPass", value);
        }
    }
}