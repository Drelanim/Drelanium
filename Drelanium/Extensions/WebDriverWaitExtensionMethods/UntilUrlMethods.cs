using System;
using System.Text.RegularExpressions;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium.Support.UI;
using Serilog.Core;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    /// <summary>To be added...</summary>
    public static class UntilUrlMethods
    {

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="url">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlToBe(this WebDriverWait wait, Uri url, Logger logger = null)
        {
            logger?.Information($"Waiting for url to be ({url.AbsoluteUri})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url to be ({url})";
            var result = wait.Until(driver => driver.Url == url.AbsoluteUri);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="url">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlNotToBe(this WebDriverWait wait, Uri url, Logger logger = null)
        {
            logger?.Information($"Waiting for url not to be ({url.AbsoluteUri})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url not to be ({url})";
            var result = wait.Until(driver => driver.Url != url.AbsoluteUri);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="fraction">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlContains(this WebDriverWait wait, string fraction, Logger logger = null)
        {
            logger?.Information($"Waiting for url to contain ({fraction})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url contains ({fraction})";
            var result = wait.Until(driver => driver.Url.Contains(fraction));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="fraction">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlContains(this WebDriverWait wait, Uri fraction, Logger logger = null)
        {
            return wait.UntilUrlContains(fraction.AbsoluteUri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="fraction">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlNotContains(this WebDriverWait wait, string fraction, Logger logger = null)
        {
            logger?.Information($"Waiting for url not to contain ({fraction})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url does not contain ({fraction})";
            var result = wait.Until(driver => !driver.Url.Contains(fraction));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="fraction">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlNotContains(this WebDriverWait wait, Uri fraction, Logger logger = null)
        {
            return wait.UntilUrlNotContains(fraction.AbsoluteUri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="regex">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlMatches(this WebDriverWait wait, string regex, Logger logger = null)
        {
            logger?.Information($"Waiting for url to match regex ({regex})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url matches ({regex}) regular expression";
            var result = wait.Until(driver => new Regex(regex).IsMatch(driver.Url));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="regex">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        public static bool UntilUrlNotMatches(this WebDriverWait wait, string regex, Logger logger = null)
        {
            logger?.Information($"Waiting for url not to match regex ({regex})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url not matches ({regex}) regular expression";
            var result = wait.Until(driver => !new Regex(regex).IsMatch(driver.Url));

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriComponents">To be added...</param>
        /// <param name="uriFormat">To be added...</param>
        public static bool UntilUrlComponentsToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, string expected, Logger logger = null)
        {
            logger?.Information($"Waiting for url ({uriComponents}) components to be ({expected})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url {uriComponents.ToString()} components to be {expected}";
            var result = wait.Until(driver => driver.Url().GetComponents(uriComponents, uriFormat) == expected);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriComponents">To be added...</param>
        /// <param name="uriFormat">To be added...</param>
        public static bool UntilUrlComponentsToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, Uri expected, Logger logger = null)
        {
            return wait.UntilUrlComponentsToBe(uriComponents, uriFormat, expected.AbsoluteUri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriComponents">To be added...</param>
        /// <param name="uriFormat">To be added...</param>
        public static bool UntilUrlComponentsNotToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, string expected, Logger logger = null)
        {
            logger?.Information($"Waiting for url ({uriComponents}) components not to be ({expected})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url {uriComponents.ToString()} components not to be {expected}";
            var result = wait.Until(driver => driver.Url().GetComponents(uriComponents, uriFormat) != expected);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriComponents">To be added...</param>
        /// <param name="uriFormat">To be added...</param>
        public static bool UntilUrlComponentsNotToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, Uri expected, Logger logger = null)
        {
            return wait.UntilUrlComponentsNotToBe(uriComponents, uriFormat, expected.AbsoluteUri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriPartial">To be added...</param>
        public static bool UntilUrlLeftPartToBe(this WebDriverWait wait, UriPartial uriPartial, string expected, Logger logger = null)
        {
            logger?.Information($"Waiting for url ({uriPartial}) left part to be ({expected})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url {uriPartial.ToString()} partial to be {expected}";
            var result = wait.Until(driver => driver.Url().GetLeftPart(uriPartial) == expected);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriPartial">To be added...</param>
        public static bool UntilUrlLeftPartToBe(this WebDriverWait wait, UriPartial uriPartial, Uri expected, Logger logger = null)
        {
            return wait.UntilUrlLeftPartToBe(uriPartial, expected.AbsoluteUri, logger);
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriPartial">To be added...</param>
        public static bool UntilUrlLeftPartNotToBe(this WebDriverWait wait, UriPartial uriPartial, string expected, Logger logger = null)
        {
            logger?.Information($"Waiting for url ({uriPartial}) left part not to be ({expected})");

            wait.Message += $"Waited ({wait.Timeout.TotalSeconds}) seconds until url {uriPartial.ToString()} partial not to be {expected}";
            var result = wait.Until(driver => driver.Url().GetLeftPart(uriPartial) != expected);

            logger?.Information("Wait is finished, condition is met!");

            return result;
        }

        /// <summary>To be added...</summary>
        /// <param name="wait">The <see cref="WebDriverWait" /> instance, that is used to command the browser for wait.</param>
        /// <param name="expected">To be added...</param>
        /// <param name="logger">The used <see cref="Logger" /> instance to display logged messages during the method exeuction.</param>
        /// <param name="uriPartial">To be added...</param>
        public static bool UntilUrlLeftPartNotToBe(this WebDriverWait wait, UriPartial uriPartial, Uri expected, Logger logger = null)
        {
            return wait.UntilUrlLeftPartNotToBe(uriPartial, expected.AbsoluteUri, logger);
        }

    }

}