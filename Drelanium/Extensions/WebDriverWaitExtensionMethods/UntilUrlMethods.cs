using System;
using System.Text.RegularExpressions;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium.Support.UI;


namespace Drelanium.Extensions.WebDriverWaitExtensionMethods
{

    public static class UntilUrlMethods
    {

        public static bool UntilUrlToBe(this WebDriverWait wait, string url)
        {
            wait.Message += $"Waited until url to be ({url})";
            return wait.Until(driver => driver.Url == url);
        }

        public static bool UntilUrlToBe(this WebDriverWait wait, Uri url)
        {
            return wait.UntilUrlToBe(url.AbsoluteUri);
        }

        public static bool UntilUrlNotToBe(this WebDriverWait wait, string url)
        {
            wait.Message += $"Waited until url not to be ({url})";
            return wait.Until(driver => driver.Url != url);
        }

        public static bool UntilUrlNotToBe(this WebDriverWait wait, Uri url)
        {
            return wait.UntilUrlNotToBe(url.AbsoluteUri);
        }

        public static bool UntilUrlContains(this WebDriverWait wait, string fraction)
        {
            wait.Message += $"Waited until url contains ({fraction})";
            return wait.Until(driver => driver.Url.Contains(fraction));
        }

        public static bool UntilUrlContains(this WebDriverWait wait, Uri fraction)
        {
            return wait.UntilUrlContains(fraction.AbsoluteUri);
        }

        public static bool UntilUrlNotContains(this WebDriverWait wait, string fraction)
        {
            wait.Message += $"Waited until url does not contain ({fraction})";
            return wait.Until(driver => !driver.Url.Contains(fraction));
        }

        public static bool UntilUrlNotContains(this WebDriverWait wait, Uri fraction)
        {
            return wait.UntilUrlNotContains(fraction.AbsoluteUri);
        }

        public static bool UntilUrlMatches(this WebDriverWait wait, string regex)
        {
            wait.Message += $"Waited until url matches ({regex}) regular expression";
            return wait.Until(driver => new Regex(regex).IsMatch(driver.Url));
        }

        public static bool UntilUrlNotMatches(this WebDriverWait wait, string regex)
        {
            wait.Message += $"Waited until url not matches ({regex}) regular expression";
            return wait.Until(driver => !new Regex(regex).IsMatch(driver.Url));
        }

        public static bool UntilUrlComponentsToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, string expected)
        {
            wait.Message += $"Waited until url {uriComponents.ToString()} components to be {expected}";
            return wait.Until(driver => driver.Url().GetComponents(uriComponents, uriFormat) == expected);
        }

        public static bool UntilUrlComponentsToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, Uri expected)
        {
            return wait.UntilUrlComponentsToBe(uriComponents, uriFormat, expected.AbsoluteUri);
        }

        public static bool UntilUrlComponentsNotToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, string expected)
        {
            wait.Message += $"Waited until url {uriComponents.ToString()} components not to be {expected}";
            return wait.Until(driver => driver.Url().GetComponents(uriComponents, uriFormat) != expected);
        }

        public static bool UntilUrlComponentsNotToBe(this WebDriverWait wait, UriComponents uriComponents, UriFormat uriFormat, Uri expected)
        {
            return wait.UntilUrlComponentsNotToBe(uriComponents, uriFormat, expected.AbsoluteUri);
        }

        public static bool UntilUrlLeftPartToBe(this WebDriverWait wait, UriPartial uriPartial, string expected)
        {
            wait.Message += $"Waited until url {uriPartial.ToString()} partial to be {expected}";
            return wait.Until(driver => driver.Url().GetLeftPart(uriPartial) == expected);
        }

        public static bool UntilUrlLeftPartToBe(this WebDriverWait wait, UriPartial uriPartial, Uri expected)
        {
            return wait.UntilUrlLeftPartToBe(uriPartial, expected.AbsoluteUri);
        }

        public static bool UntilUrlLeftPartNotToBe(this WebDriverWait wait, UriPartial uriPartial, string expected)
        {
            wait.Message += $"Waited until url {uriPartial.ToString()} partial not to be {expected}";
            return wait.Until(driver => driver.Url().GetLeftPart(uriPartial) != expected);
        }

        public static bool UntilUrlLeftPartNotToBe(this WebDriverWait wait, UriPartial uriPartial, Uri expected)
        {
            return wait.UntilUrlLeftPartNotToBe(uriPartial, expected.AbsoluteUri);
        }

    }

}