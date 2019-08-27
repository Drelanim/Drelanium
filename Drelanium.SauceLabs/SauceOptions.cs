using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;


// ReSharper disable InconsistentNaming
#pragma warning disable 1591


namespace Drelanium.SauceLabs
{
    /// <summary>
    /// 
    /// </summary>
    public class SauceOptions
    {
        private Dictionary<string, object> GetDictionary()
        {
            var json = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="driverOptions"></param>
        /// <exception cref="ArgumentException"></exception>
        public void AddToDriverOptions(DriverOptions driverOptions)
        {
            var sauceOptionsDictionary = GetDictionary();


            switch (driverOptions)
            {
                case ChromeOptions chromeOptions:
                {
                    chromeOptions.AddAdditionalCapability("sauce:options", sauceOptionsDictionary, true);
                    break;
                }


                case FirefoxOptions firefoxOptions:
                {
                    firefoxOptions.AddAdditionalCapability("sauce:options", sauceOptionsDictionary, true);
                    break;
                }


                case InternetExplorerOptions internetExplorerOptions:
                {
                    internetExplorerOptions.AddAdditionalCapability("sauce:options", sauceOptionsDictionary, true);
                    break;
                }


                case OperaOptions operaOptions:
                {
                    operaOptions.AddAdditionalCapability("sauce:options", sauceOptionsDictionary, true);
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


        public object accessKey;


        public object appiumVersion;


        public object avoidProxy;


        public object build;

        public object captureHtml;


        public object chromedriverVersion;

        public object crmuxdriverVersion;


        public object customData;


        public object disablePopupHandler;

        public object extendedDebugging;

        public object firefoxAdapterVersion;

        public object firefoxProfileUrl;


        public object idleTimeout;

        public object iedriverVersion;


        public object maxDuration;

        public object name;

        public object parentTunnel;


        public object passed;

        public object prerun;


        public object preserveRequeue;

        public object priority;


        public object proxyHost;

        public object @public;

        public object recordLogs;

        public object recordScreenshots;


        public object restrictedPublicInfo;

        public object screenResolution;
        public object seleniumVersion;

        public object source;

        public object tags;


        public object timeZone;

        public object tunnelIdentifier;


        public object username;

        public object videoUploadOnPass;
    }
}