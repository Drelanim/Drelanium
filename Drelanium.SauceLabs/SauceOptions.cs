using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;


// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable InconsistentNaming
#pragma warning disable 1591
#pragma warning disable IDE1006 // Naming Styles


namespace Drelanium.SauceLabs
{
    /// <summary>
    /// </summary>
    public class SauceOptions
    {
        /// <summary>
        /// </summary>
        public SauceOptions()
        {
            Options = new Dictionary<string, object>();
        }

        /// <summary>
        /// </summary>
        public Dictionary<string, object> Options { get; }


        public object accessKey
        {
            get => GetValue("accessKey");
            set => SetValue("accessKey", value);
        }


        public object appiumVersion
        {
            get => GetValue("appiumVersion");
            set => SetValue("appiumVersion", value);
        }


        public object avoidProxy
        {
            get => GetValue("avoidProxy");
            set => SetValue("avoidProxy", value);
        }


        public object build
        {
            get => GetValue("build");
            set => SetValue("build", value);
        }


        public object captureHtml
        {
            get => GetValue("captureHtml");
            set => SetValue("captureHtml", value);
        }


        public object chromedriverVersion
        {
            get => GetValue("chromedriverVersion");
            set => SetValue("chromedriverVersion", value);
        }


        public object crmuxdriverVersion
        {
            get => GetValue("crmuxdriverVersion");
            set => SetValue("crmuxdriverVersion", value);
        }


        public object customData
        {
            get => GetValue("customData");
            set => SetValue("customData", value);
        }


        public object disablePopupHandler
        {
            get => GetValue("disablePopupHandler");
            set => SetValue("disablePopupHandler", value);
        }


        public object extendedDebugging
        {
            get => GetValue("extendedDebugging");
            set => SetValue("extendedDebugging", value);
        }


        public object firefoxAdapterVersion
        {
            get => GetValue("firefoxAdapterVersion");
            set => SetValue("firefoxAdapterVersion", value);
        }


        public object firefoxProfileUrl
        {
            get => GetValue("firefoxProfileUrl");
            set => SetValue("firefoxProfileUrl", value);
        }


        public object idleTimeout
        {
            get => GetValue("idleTimeout");
            set => SetValue("idleTimeout", value);
        }


        public object iedriverVersion
        {
            get => GetValue("iedriverVersion");
            set => SetValue("iedriverVersion", value);
        }

        public object maxDuration
        {
            get => GetValue("maxDuration");
            set => SetValue("maxDuration", value);
        }


        public object name
        {
            get => GetValue("name");
            set => SetValue("name", value);
        }


        public object parentTunnel
        {
            get => GetValue("parentTunnel");
            set => SetValue("parentTunnel", value);
        }


        public object passed
        {
            get => GetValue("passed");
            set => SetValue("passed", value);
        }


        public object prerun
        {
            get => GetValue("prerun");
            set => SetValue("prerun", value);
        }


        public object preserveRequeue
        {
            get => GetValue("preserveRequeue");
            set => SetValue("preserveRequeue", value);
        }


        public object priority
        {
            get => GetValue("priority");
            set => SetValue("priority", value);
        }


        public object proxyHost
        {
            get => GetValue("proxyHost");
            set => SetValue("proxyHost", value);
        }

        public object @public
        {
            get => GetValue("public");
            set => SetValue("public", value);
        }


        public object recordLogs
        {
            get => GetValue("recordLogs");
            set => SetValue("recordLogs", value);
        }


        public object recordScreenshots
        {
            get => GetValue("recordScreenshots");
            set => SetValue("recordScreenshots", value);
        }


        public object restrictedPublicInfo
        {
            get => GetValue("restrictedPublicInfo");
            set => SetValue("restrictedPublicInfo", value);
        }


        public object screenResolution
        {
            get => GetValue("screenResolution");
            set => SetValue("screenResolution", value);
        }

        public object seleniumVersion
        {
            get => GetValue("seleniumVersion");
            set => SetValue("seleniumVersion", value);
        }

        public object source
        {
            get => GetValue("source");
            set => SetValue("source", value);
        }


        public object tags
        {
            get => GetValue("tags");
            set => SetValue("tags", value);
        }


        public object timeZone
        {
            get => GetValue("timeZone");
            set => SetValue("timeZone", value);
        }


        public object tunnelIdentifier
        {
            get => GetValue("tunnelIdentifier");
            set => SetValue("tunnelIdentifier", value);
        }


        public object username
        {
            get => GetValue("username");
            set => SetValue("username", value);
        }


        public object videoUploadOnPass
        {
            get => GetValue("videoUploadOnPass");
            set => SetValue("videoUploadOnPass", value);
        }


        /// <summary>
        /// </summary>
        /// <param name="configurationRoot"></param>
        /// <returns></returns>
        public SauceOptions Bind(IConfigurationRoot configurationRoot)
        {
            configurationRoot.Bind(this);
            return this;
        }


        /// <summary>
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <returns></returns>
        public SauceOptions Bind(string jsonPath)
        {
            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
        }


        /// <summary>
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
            return Options.ContainsKey(key) ? Options[key] : null;
        }


        private void SetValue(string key, object value)
        {
            if (value == null)
            {
                return;
            }

            if (!Options.ContainsKey(key))
            {
                Options.Add(key, value);
            }

            Options[key] = value;
        }
    }
}