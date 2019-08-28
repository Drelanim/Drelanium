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


        public string accessKey
        {
            get => GetValue("accessKey")?.ToString();
            set => SetValue("accessKey", value);
        }


        public string appiumVersion
        {
            get => GetValue("appiumVersion")?.ToString();
            set => SetValue("appiumVersion", value);
        }


        public bool avoidProxy
        {
            get => GetValue("avoidProxy")?.ToString()?.ToLower() == "true";
            set => SetValue("avoidProxy", value);
        }


        public string build
        {
            get => GetValue("build")?.ToString();
            set => SetValue("build", value);
        }


        public object captureHtml
        {
            get => GetValue("captureHtml");
            set => SetValue("captureHtml", value);
        }


        public string chromedriverVersion
        {
            get => GetValue("chromedriverVersion")?.ToString();
            set => SetValue("chromedriverVersion", value);
        }


        public string crmuxdriverVersion
        {
            get => GetValue("crmuxdriverVersion")?.ToString();
            set => SetValue("crmuxdriverVersion", value);
        }


        public object customData
        {
            get => GetValue("customData");
            set => SetValue("customData", value);
        }


        public bool disablePopupHandler
        {
            get => GetValue("disablePopupHandler")?.ToString()?.ToLower() == "true";
            set => SetValue("disablePopupHandler", value);
        }


        public bool extendedDebugging
        {
            get => GetValue("extendedDebugging")?.ToString()?.ToLower() == "true";
            set => SetValue("extendedDebugging", value);
        }


        public string firefoxAdapterVersion
        {
            get => GetValue("firefoxAdapterVersion")?.ToString();
            set => SetValue("firefoxAdapterVersion", value);
        }


        public string firefoxProfileUrl
        {
            get => GetValue("firefoxProfileUrl")?.ToString();
            set => SetValue("firefoxProfileUrl", value);
        }


        public int idleTimeout
        {
            get => GetValue("idleTimeout") == null ? 0 : int.Parse(GetValue("idleTimeout").ToString());
            set => SetValue("idleTimeout", value);
        }


        public string iedriverVersion
        {
            get => GetValue("iedriverVersion")?.ToString();
            set => SetValue("iedriverVersion", value);
        }

        public int maxDuration
        {
            get => GetValue("maxDuration") == null ? 0 : int.Parse(GetValue("maxDuration").ToString());
            set => SetValue("maxDuration", value);
        }


        public string name
        {
            get => GetValue("name")?.ToString();
            set => SetValue("name", value);
        }


        public string parentTunnel
        {
            get => GetValue("parentTunnel")?.ToString();
            set => SetValue("parentTunnel", value);
        }


        public bool passed
        {
            get => GetValue("passed")?.ToString()?.ToLower() == "true";
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


        public int priority
        {
            get => GetValue("priority") == null ? 0 : int.Parse(GetValue("priority").ToString());
            set => SetValue("priority", value);
        }


        public object proxyHost
        {
            get => GetValue("proxyHost");
            set => SetValue("proxyHost", value);
        }

        public string @public
        {
            get => GetValue("public")?.ToString();
            set => SetValue("public", value);
        }


        public bool recordLogs
        {
            get => GetValue("recordLogs")?.ToString()?.ToLower() == "true";
            set => SetValue("recordLogs", value);
        }


        public bool recordScreenshots
        {
            get => GetValue("recordScreenshots")?.ToString()?.ToLower() == "true";
            set => SetValue("recordScreenshots", value);
        }


        public object restrictedPublicInfo
        {
            get => GetValue("restrictedPublicInfo");
            set => SetValue("restrictedPublicInfo", value);
        }


        public string screenResolution
        {
            get => GetValue("screenResolution")?.ToString();
            set => SetValue("screenResolution", value);
        }

        public string seleniumVersion
        {
            get => GetValue("seleniumVersion")?.ToString();
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


        public string timeZone
        {
            get => GetValue("timeZone")?.ToString();
            set => SetValue("timeZone", value);
        }


        public string tunnelIdentifier
        {
            get => GetValue("tunnelIdentifier")?.ToString();
            set => SetValue("tunnelIdentifier", value);
        }


        public string username
        {
            get => GetValue("username")?.ToString();
            set => SetValue("username", value);
        }


        public bool videoUploadOnPass
        {
            get => GetValue("videoUploadOnPass")?.ToString()?.ToLower() == "true";
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
            return !Options.ContainsKey(key) ? null : Options[key];
        }


        private void SetValue(string key, object value)
        {
            if (!Options.ContainsKey(key))
            {
                Options.Add(key, null);
            }

            Options[key] = value;
        }
    }
}