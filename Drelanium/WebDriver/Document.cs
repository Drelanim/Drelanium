using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Drelanium.Extensions.IWebDriverExtensionMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


// ReSharper disable InconsistentNaming
public enum DocumentReadyState
{

    loading,

    interactive,

    complete

}


namespace Drelanium.WebDriver
{

    public class Document
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Document(IWebDriver driver)
        {


            Driver = driver;
        }

        private IWebDriver Driver { get; }
        public IWebElement ActiveElement => Driver.ExecuteJavaScript<IWebElement>("return document['activeElement']; ");
        public Uri BaseURI => new Uri(Driver.ExecuteJavaScript<object>("return document['baseURI']; ").ToString());
        public IWebElement Body => Driver.ExecuteJavaScript<IWebElement>("return document['body']; ");
        public IWebElement DocumentElement => Driver.ExecuteJavaScript<IWebElement>("return document['documentElement']; ");
        public Uri DocumentURI => new Uri(Driver.ExecuteJavaScript<object>("return document['documentURI']; ").ToString());
        public string Domain => Driver.ExecuteJavaScript<object>("return document['domain']; ").ToString();
        public IWebElement Head => Driver.ExecuteJavaScript<IWebElement>("return document['head']; ");
        public ReadOnlyCollection<IWebElement> Links => Driver.ExecuteJavaScript<ReadOnlyCollection<IWebElement>>("return document['links']; ");

        public DocumentReadyState ReadyState
        {
            get
            {
                var documentReadyState = Driver.ExecuteJavaScript<object>("return document['readyState']; ").ToString();

                switch (documentReadyState)
                {
                    case "loading":
                        return DocumentReadyState.loading;

                    case "interactive":
                        return DocumentReadyState.interactive;

                    case "complete":
                        return DocumentReadyState.complete;

                    default:
                        throw new InvalidEnumArgumentException();
                }
            }
        }

        public string Referrer => Driver.ExecuteJavaScript<object>("return document['referrer']; ").ToString();
        public string Title => Driver.ExecuteJavaScript<object>("return document['title']; ").ToString();
        public Uri URL => new Uri(Driver.ExecuteJavaScript<object>("return document['URL']; ").ToString());

    }

}