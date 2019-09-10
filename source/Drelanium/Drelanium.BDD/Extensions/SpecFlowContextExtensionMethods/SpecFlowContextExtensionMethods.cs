using System.Collections.Generic;
using OpenQA.Selenium;
using Serilog.Core;
using Serilog.Events;
using TechTalk.SpecFlow;

namespace Drelanium.BDD
{
    /// <summary>
    ///     Extension methods for <see cref="SpecFlowContext" /> types.
    /// </summary>
    public static class SpecFlowContextExtensionMethods
    {
        /// <summary>
        ///     Gets the stored <see cref="IPageObject" /> from the <see cref="SpecFlowContext" /> using it's type as key.
        /// </summary>
        /// <param name="specFlowContext">A Context object, which serves as a <see cref="Dictionary{TKey,TValue}" />.</param>
        public static IPageObject GetCurrentPageObject(this SpecFlowContext specFlowContext)
        {
            return specFlowContext.Get<IPageObject>();
        }

        /// <summary>
        ///     Gets the stored <see cref="IWebDriver" /> from the <see cref="SpecFlowContext" /> using it's type as key.
        /// </summary>
        /// <param name="specFlowContext">A Context object, which serves as a <see cref="Dictionary{TKey,TValue}" />.</param>
        public static IWebDriver GetDriver(this SpecFlowContext specFlowContext)
        {
            return specFlowContext.Get<IWebDriver>();
        }

        /// <summary>
        ///     Gets the stored <see cref="Logger" /> from the <see cref="SpecFlowContext" /> using it's type as key.
        /// </summary>
        /// <param name="specFlowContext">A Context object, which serves as a <see cref="Dictionary{TKey,TValue}" />.</param>
        public static Logger GetLogger(this SpecFlowContext specFlowContext)
        {
            return specFlowContext.Get<Logger>();
        }

        /// <summary>
        ///     Sets the given <see cref="IPageObject" /> to the <see cref="SpecFlowContext" /> using it's type as key.
        /// </summary>
        /// <param name="specFlowContext">A Context object, which serves as a <see cref="Dictionary{TKey,TValue}" />.</param>
        /// <param name="pageObject">The <see cref="IPageObject" /> object, that is currently in use.</param>
        public static void SetCurrentPageObject(this SpecFlowContext specFlowContext, IPageObject pageObject)
        {
            specFlowContext.Set(pageObject);
        }

        /// <summary>
        ///     Sets the given <see cref="IWebDriver" /> to the <see cref="SpecFlowContext" /> using it's type as key.
        /// </summary>
        /// <param name="specFlowContext">A Context object, which serves as a <see cref="Dictionary{TKey,TValue}" />.</param>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public static void SetDriver(this SpecFlowContext specFlowContext, IWebDriver driver)
        {
            specFlowContext.Set(driver);
        }

        /// <summary>
        ///     Sets the given <see cref="Logger" /> to the <see cref="SpecFlowContext" /> using it's type as key.
        /// </summary>
        /// <param name="specFlowContext">A Context object, which serves as a <see cref="Dictionary{TKey,TValue}" />.</param>
        /// <param name="logger">
        ///     The used <see cref="Logger" /> instance to display logged messages (<see cref="LogEventLevel" /> =
        ///     <see cref="LogEventLevel.Information" />) during
        ///     the method exeuction.
        /// </param>
        public static void SetLogger(this SpecFlowContext specFlowContext, Logger logger)
        {
            specFlowContext.Set(logger);
        }
    }
}