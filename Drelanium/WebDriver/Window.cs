using System.Drawing;
using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
    /// Extended implementation of <see cref="IWindow"/>
    /// </summary>
    public class Window : IWindow
    {
        /// <summary>
        /// <see cref="Window"/>
        ///</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Window(IWebDriver driver)
        {
            Driver = driver;
            WindowImplementation = driver.Manage().Window;
        }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="IWindow"/>
        private IWindow WindowImplementation { get; }

        /// <summary>
        ///
        /// </summary>
        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }

        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void Maximize()
        {
            WindowImplementation.Maximize();
        }

        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void Minimize()
        {
            WindowImplementation.Minimize();
        }

        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public void FullScreen()
        {
            WindowImplementation.FullScreen();
        }

        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public Point Position
        {
            get => WindowImplementation.Position;
            set => WindowImplementation.Position = value;
        }

        /// <summary>
        /// <inheritdoc></inheritdoc>
        /// </summary>
        public Size Size
        {
            get => WindowImplementation.Size;
            set => WindowImplementation.Size = value;
        }
    }
}