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

#pragma warning disable IDE1006 // Naming Styles


namespace Drelanium.SauceLabs
{
    /// <summary>
    ///     TO be addedd..
    /// </summary>
    public class SauceOptions
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public SauceOptions()
        {
            Options = new Dictionary<string, object>();
        }

        /// <summary>
        ///     To be addedd...
        /// </summary>
        public Dictionary<string, object> Options { get; }


        /// <summary>
        ///     <para> group: Required Selenium Test Configuration Setting </para>
        ///     <para> group: Required Appium Test Configuration Setting </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "firefox" </para>
        /// </summary>
        public object browserName
        {
            get => GetValue("browserName.");
            set => SetValue("browserName", value);
        }


        /// <summary>
        ///     <para> group: Required Appium Test Configuration Settings </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "Google Nexus 7 HD Emulator" </para>
        /// </summary>
        public object deviceName
        {
            get => GetValue("deviceName.");
            set => SetValue("deviceName", value);
        }


        /// <summary>
        ///     <para> group: Other Appium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "tablet" </para>
        /// </summary>
        public object deviceType
        {
            get => GetValue("deviceType.");
            set => SetValue("deviceType", value);
        }


        /// <summary>
        ///     <para> group: Other Appium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "portrait" </para>
        /// </summary>
        public object deviceOrientation
        {
            get => GetValue("deviceOrientation.");
            set => SetValue("deviceOrientation", value);
        }


        /// <summary>
        ///     <para> group: Other Appium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "UiAutomator2" </para>
        /// </summary>
        public object automationName
        {
            get => GetValue("automationName.");
            set => SetValue("automationName", value);
        }


        /// <summary>
        ///     <para> group: Other Appium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "com.example.android.myApp, com.android.settings" </para>
        /// </summary>
        public object appPackage
        {
            get => GetValue("appPackage.");
            set => SetValue("appPackage", value);
        }


        /// <summary>
        ///     <para> group: Other Appium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: ".MainActivity" </para>
        /// </summary>
        public object appActivity
        {
            get => GetValue("appActivity.");
            set => SetValue("appActivity", value);
        }


        /// <summary>
        ///     <para> group: General Options - Alerts </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: true </para>
        /// </summary>
        public object autoAcceptAlerts
        {
            get => GetValue("autoAcceptAlerts.");
            set => SetValue("autoAcceptAlerts", value);
        }


        /// <summary>
        ///     <para> group: Required Selenium Test Configuration Setting </para>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "66.0" </para>
        /// </summary>
        public object version
        {
            get => GetValue("version.");
            set => SetValue("version", value);
        }


        /// <summary>
        ///     <para> group: Required Selenium Test Configuration Setting </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "macOS 10.13" </para>
        /// </summary>
        public object platform
        {
            get => GetValue("platform.");
            set => SetValue("platform", value);
        }


        /// <summary>
        ///     <para> group: Required Appium Test Configuration Setting </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "9.1" </para>
        /// </summary>
        public object platformVersion
        {
            get => GetValue("platformVersion.");
            set => SetValue("platformVersion", value);
        }


        /// <summary>
        ///     <para> group: Required Appium Test Configuration Setting </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "sauce-storage:my_app.zip" </para>
        /// </summary>
        public object app
        {
            get => GetValue("app.");
            set => SetValue("app", value);
        }


        /// <summary>
        ///     <para> group: Required Appium Test Configuration Setting </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "iOS" </para>
        /// </summary>
        public object platformName
        {
            get => GetValue("platformName.");
            set => SetValue("platformName", value);
        }


        /// <summary>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "12345678-1234-1234-1234-123456789012" </para>
        /// </summary>
        public object accessKey
        {
            get => GetValue("accessKey.");
            set => SetValue("accessKey", value);
        }


        /// <summary>
        ///     <para> group: Required Appium Test Configuration Settings </para>
        ///     <para> group: Other Appium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "1.5.3" </para>
        /// </summary>
        public object appiumVersion
        {
            get => GetValue("appiumVersion.");
            set => SetValue("appiumVersion", value);
        }


        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: true </para>
        /// </summary>
        public object avoidProxy
        {
            get => GetValue("avoidProxy.");
            set => SetValue("avoidProxy", value);
        }


        /// <summary>
        ///     <para> group: General Options - Test Annotation </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "build-1234" </para>
        /// </summary>
        public object build
        {
            get => GetValue("build.");
            set => SetValue("build", value);
        }


        /// <summary>
        /// </summary>
        public object captureHtml
        {
            get => GetValue("captureHtml.");
            set => SetValue("captureHtml", value);
        }


        /// <summary>
        ///     <para> group: Other Selenium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "chromedriverVersion": "2.45" </para>
        /// </summary>
        public object chromedriverVersion
        {
            get => GetValue("chromedriverVersion.");
            set => SetValue("chromedriverVersion", value);
        }


        /// <summary>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "2.45" </para>
        /// </summary>
        public object crmuxdriverVersion
        {
            get => GetValue("crmuxdriverVersion.");
            set => SetValue("crmuxdriverVersion", value);
        }


        /// <summary>
        ///     <para> group: General Options - Test Annotation </para>
        ///     <para> type: <see cref="object" /> </para>
        ///     <para>
        ///         example: {"release": "1.0", "commit": "0k392a9dkjr", "staging": true, "execution_number": 5, "server":
        ///         "test.customer.com"}
        ///     </para>
        /// </summary>
        public object customData
        {
            get => GetValue("customData.");
            set => SetValue("customData", value);
        }


        /// <summary>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: true </para>
        /// </summary>
        public object disablePopupHandler
        {
            get => GetValue("disablePopupHandler.");
            set => SetValue("disablePopupHandler", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: true </para>
        /// </summary>
        public object extendedDebugging
        {
            get => GetValue("extendedDebugging.");
            set => SetValue("extendedDebugging", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: true </para>
        /// </summary>
        public object capturePerformance
        {
            get => GetValue("capturePerformance.");
            set => SetValue("capturePerformance", value);
        }


        /// <summary>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "1.0" </para>
        /// </summary>
        public object firefoxAdapterVersion
        {
            get => GetValue("firefoxAdapterVersion.");
            set => SetValue("firefoxAdapterVersion", value);
        }


        /// <summary>
        ///     <para> type: <see cref="string" /> </para>
        /// </summary>
        public object firefoxProfileUrl
        {
            get => GetValue("firefoxProfileUrl.");
            set => SetValue("firefoxProfileUrl", value);
        }

        /// <summary>
        ///     <para> General Options: Timeouts </para>
        ///     <para> type: <see cref="int" /> </para>
        ///     <para> example: 90 </para>
        /// </summary>
        public object idleTimeout
        {
            get => GetValue("idleTimeout.");
            set => SetValue("idleTimeout", value);
        }


        /// <summary>
        ///     <para> General Options: Timeouts </para>
        ///     <para> type: <see cref="int" /> </para>
        ///     <para> example: 300 </para>
        /// </summary>
        public object commandTimeout
        {
            get => GetValue("commandTimeout.");
            set => SetValue("commandTimeout", value);
        }


        /// <summary>
        ///     <para> group: Other Selenium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "3.141.0" </para>
        /// </summary>
        public object iedriverVersion
        {
            get => GetValue("iedriverVersion.");
            set => SetValue("iedriverVersion", value);
        }


        /// <summary>
        ///     <para> General Options: Timeouts </para>
        ///     <para> type: <see cref="int" /> </para>
        ///     <para> example: 1800 </para>
        /// </summary>

        public object maxDuration
        {
            get => GetValue("maxDuration.");
            set => SetValue("maxDuration", value);
        }


        /// <summary>
        ///     <para> group: General Options - Test Annotation </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "my example name" </para>
        /// </summary>
        public object name
        {
            get => GetValue("name.");
            set => SetValue("name", value);
        }


        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "MyTunnel01" </para>
        /// </summary>
        public object parentTunnel
        {
            get => GetValue("parentTunnel.");
            set => SetValue("parentTunnel", value);
        }

        /// <summary>
        ///     <para> group: General Options - Test Annotation </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: true </para>
        /// </summary>

        public object passed
        {
            get => GetValue("passed.");
            set => SetValue("passed", value);
        }


        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        /// </summary>
        public object prerun
        {
            get => GetValue("prerun.");
            set => SetValue("prerun", value);
        }


        /// <summary>
        /// </summary>
        public object preserveRequeue
        {
            get => GetValue("preserveRequeue.");
            set => SetValue("preserveRequeue", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="int" /> </para>
        ///     <para> example: 0 </para>
        /// </summary>
        public object priority
        {
            get => GetValue("priority.");
            set => SetValue("priority", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: false </para>
        /// </summary>
        public object webdriverRemoteQuietExceptions
        {
            get => GetValue("webdriver.remote.quietExceptions.");
            set => SetValue("webdriver.remote.quietExceptions", value);
        }


        /// <summary>
        /// </summary>
        public object proxyHost
        {
            get => GetValue("proxyHost.");
            set => SetValue("proxyHost", value);
        }

        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "public" </para>
        /// </summary>
        public object @public
        {
            get => GetValue("public.");
            set => SetValue("public", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: false </para>
        /// </summary>
        public object recordLogs
        {
            get => GetValue("recordLogs.");
            set => SetValue("recordLogs", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: false </para>
        /// </summary>
        public object recordVideo
        {
            get => GetValue("recordVideo.");
            set => SetValue("recordVideo", value);
        }


        /// <summary>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: false </para>
        /// </summary>
        public object recordScreenshots
        {
            get => GetValue("recordScreenshots.");
            set => SetValue("recordScreenshots", value);
        }


        /// <summary>
        /// </summary>
        public object restrictedPublicInfo
        {
            get => GetValue("restrictedPublicInfo.");
            set => SetValue("restrictedPublicInfo", value);
        }


        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "1280x1024" </para>
        /// </summary>
        public object screenResolution
        {
            get => GetValue("screenResolution.");
            set => SetValue("screenResolution", value);
        }

        /// <summary>
        ///     <para> group: Other Selenium Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "seleniumVersion": "2.46.0" </para>
        /// </summary>
        public object seleniumVersion
        {
            get => GetValue("seleniumVersion.");
            set => SetValue("seleniumVersion", value);
        }


        /// <summary>
        /// </summary>
        public object source
        {
            get => GetValue("source.");
            set => SetValue("source", value);
        }

        /// <summary>
        ///     <para> group: General Options - Test Annotation </para>
        ///     <para> type: <see cref="List{T}" /> </para>
        ///     <para> example: ["tag1","tag2","tag3"] </para>
        /// </summary>

        public object tags
        {
            get => GetValue("tags.");
            set => SetValue("tags", value);
        }


        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "Los_Angeles"  </para>
        /// </summary>
        public object timeZone
        {
            get => GetValue("timeZone.");
            set => SetValue("timeZone", value);
        }


        /// <summary>
        ///     <para> group: SauceTesting Options </para>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: "MyTunnel01" </para>
        /// </summary>
        public object tunnelIdentifier
        {
            get => GetValue("tunnelIdentifier.");
            set => SetValue("tunnelIdentifier", value);
        }


        /// <summary>
        ///     <para> type: <see cref="string" /> </para>
        ///     <para> example: Drelanim </para>
        /// </summary>

        public object username
        {
            get => GetValue("username.");
            set => SetValue("username", value);
        }


        /// <summary>
        ///     <para> group: Other SauceTesting Features </para>
        ///     <para> type: <see cref="bool" /> </para>
        ///     <para> example: false </para>
        /// </summary>
        public object videoUploadOnPass
        {
            get => GetValue("videoUploadOnPass.");
            set => SetValue("videoUploadOnPass", value);
        }


        /// <summary>
        /// </summary>
        /// <param name="driverOptions">...Description to be added...</param>
        /// <exception cref="ArgumentException">...Description to be added...</exception>
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
                    throw new ArgumentException("SauceOptions cannot be added as a capability to a SafariOptions.");
                }

                default:
                {
                    throw new ArgumentException("SauceOptions cannot be added as a capability.");
                }
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="configurationRoot">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public SauceOptions Bind(IConfigurationRoot configurationRoot)
        {
            configurationRoot.Bind(this);
            return this;
        }


        /// <summary>
        /// </summary>
        /// <param name="jsonPath">...Description to be added...</param>
        /// <returns>...Description to be added...</returns>
        public SauceOptions Bind(string jsonPath)
        {
            new ConfigurationBuilder().AddJsonFile(jsonPath).Build().Bind(this);
            return this;
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