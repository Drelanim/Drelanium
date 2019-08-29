using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

#pragma warning disable 1591

namespace Drelanium.WebDriver
{
    // ReSharper disable InconsistentNaming
    /// <summary>
    ///     To be added...
    /// </summary>
    public enum DocumentReadyState
    {
        /// <summary>
        /// </summary>
        loading,

        interactive,

        complete
    }

    /// <summary>
    ///     To be added...
    /// </summary>
    public class Document
    {
        /// <summary>
        ///     To be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Document(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// </summary>
        /// <inheritdoc cref="IWebDriver" />
        private IWebDriver Driver { get; }


        /// <summary>
        ///     The <see cref="IWebElement" /> that is currently focused.
        /// </summary>
        public IWebElement ActiveElement =>
            Driver.ExecuteJavaScript<IWebElement>("return document['activeElement']; .");


        /// <summary>
        ///     To be added...
        /// </summary>
        public Uri BaseURI => new Uri(Driver.ExecuteJavaScript<object>("return document['baseURI']; ").ToString());


        /// <summary>
        ///     The body <see cref="IWebElement" /> of the html.
        /// </summary>
        public IWebElement Body => Driver.ExecuteJavaScript<IWebElement>("return document['body']; .");

        /// <summary>
        ///     The document <see cref="IWebElement" /> of the html.
        /// </summary>
        public IWebElement DocumentElement =>
            Driver.ExecuteJavaScript<IWebElement>("return document['documentElement']; .");

        /// <summary>
        ///     To be added...
        /// </summary>
        public Uri DocumentURI =>
            new Uri(Driver.ExecuteJavaScript<object>("return document['documentURI']; ").ToString());

        /// <summary>
        ///     The domain part of the current Url.
        /// </summary>
        public string Domain => Driver.ExecuteJavaScript<object>("return document['domain']; ").ToString();

        /// <summary>
        ///     The head <see cref="IWebElement" /> of the html.
        /// </summary>
        public IWebElement Head => Driver.ExecuteJavaScript<IWebElement>("return document['head']; .");

        /// <summary>
        ///     To be added...
        /// </summary>
        public ReadOnlyCollection<IWebElement> Links =>
            Driver.ExecuteJavaScript<ReadOnlyCollection<IWebElement>>("return document['links']; .");

        /// <summary>
        ///     To be added...
        /// </summary>
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

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Referrer => Driver.ExecuteJavaScript<object>("return document['referrer']; ").ToString();

        /// <summary>
        ///     To be added...
        /// </summary>
        public string Title => Driver.ExecuteJavaScript<object>("return document['title']; ").ToString();

        /// <summary>
        ///     To be added...
        /// </summary>
        public Uri URL => new Uri(Driver.ExecuteJavaScript<object>("return document['URL']; ").ToString());
    }
}