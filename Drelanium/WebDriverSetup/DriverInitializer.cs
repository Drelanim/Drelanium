using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using Serilog.Core;

namespace Drelanium.WebDriverSetup
{
    /// <summary>To be added...</summary>
    public static class DriverInitializer
    {
        /// <summary>To be added...</summary>
        /// <param name="executionMode">To be added...</param>
        /// <param name="browserType">To be added...</param>
        /// <param name="driverOptions">To be added...</param>
        /// <param name="localDriverDirectory">To be added...</param>
        /// <param name="seleniumGridHubUrl">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static IWebDriver StartWebDriver(
            ExecutionMode executionMode,
            BrowserType browserType,
            DriverOptions driverOptions,
            string localDriverDirectory = null,
            Uri seleniumGridHubUrl = null,
            Logger logger = null)
        {
            IWebDriver driver;

            switch (executionMode)
            {
                case ExecutionMode.LOCAL:
                {
                    logger?.Information($"Attempting to start a ({browserType}) WebDriver on " +
                                        $"({executionMode}) ExecutionMode, " +
                                        $"using local driver directory ({localDriverDirectory}) " +
                                        $"with the following DriverOptions: ({driverOptions})");


                    if (localDriverDirectory == null)
                    {
                        var errorMessage =
                            $"Using WebDriver in ({ExecutionMode.LOCAL}) mode requires a valid local path for the WebDriver.";

                        logger?.Error(errorMessage);


                        throw new ArgumentException(errorMessage);
                    }


                    switch (browserType)
                    {
                        case BrowserType.CHROME:
                        {
                            driver = new ChromeDriver(localDriverDirectory, (ChromeOptions) driverOptions);
                            break;
                        }

                        case BrowserType.EDGE:
                        {
                            driver = new EdgeDriver(localDriverDirectory, (EdgeOptions) driverOptions);
                            break;
                        }

                        case BrowserType.FIREFOX:
                        {
                            driver = new FirefoxDriver(localDriverDirectory, (FirefoxOptions) driverOptions);
                            break;
                        }

                        case BrowserType.INTERNETEXPLROER:
                        {
                            driver = new InternetExplorerDriver(localDriverDirectory,
                                (InternetExplorerOptions) driverOptions);
                            break;
                        }

                        case BrowserType.SAFARI:
                        {
                            driver = new SafariDriver(localDriverDirectory, (SafariOptions) driverOptions);
                            break;
                        }

                        case BrowserType.OPERA:
                        {
                            driver = new OperaDriver(localDriverDirectory, (OperaOptions) driverOptions);
                            break;
                        }

                        default:
                        {
                            throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
                        }
                    }
                }

                    break;

                case ExecutionMode.REMOTE:
                {
                    logger?.Information($"Attempting to start a ({browserType}) WebDriver on " +
                                        $"({executionMode}) ExecutionMode, " +
                                        $"using SeleniumGrid Hub Url ({seleniumGridHubUrl?.AbsoluteUri}) " +
                                        $"with the following DriverOptions: ({driverOptions})");


                    if (seleniumGridHubUrl == null)
                    {
                        var errorMessage =
                            $"Using WebDriver in ({ExecutionMode.REMOTE}) mode requires a valid url to connect to a SeleniumGrid Hub.";


                        logger?.Error(errorMessage);


                        throw new ArgumentException(errorMessage);
                    }


                    switch (browserType)
                    {
                        case BrowserType.CHROME:
                        {
                            driver = new RemoteWebDriver(seleniumGridHubUrl, (ChromeOptions) driverOptions);
                            break;
                        }

                        case BrowserType.EDGE:
                        {
                            driver = new RemoteWebDriver(seleniumGridHubUrl, (EdgeOptions) driverOptions);
                            break;
                        }

                        case BrowserType.FIREFOX:
                        {
                            driver = new RemoteWebDriver(seleniumGridHubUrl, (FirefoxOptions) driverOptions);
                            break;
                        }

                        case BrowserType.INTERNETEXPLROER:
                        {
                            driver = new RemoteWebDriver(seleniumGridHubUrl, (FirefoxOptions) driverOptions);
                            break;
                        }

                        case BrowserType.SAFARI:
                        {
                            driver = new RemoteWebDriver(seleniumGridHubUrl, (SafariOptions) driverOptions);
                            break;
                        }

                        case BrowserType.OPERA:
                        {
                            driver = new RemoteWebDriver(seleniumGridHubUrl, (OperaOptions) driverOptions);
                            break;
                        }

                        default:
                        {
                            throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
                        }
                    }
                }

                    break;

                default:
                {
                    throw new ArgumentOutOfRangeException(nameof(executionMode), executionMode, null);
                }
            }

            logger?.Information("WebDriver has been started successfully");

            return driver;
        }
    }
}