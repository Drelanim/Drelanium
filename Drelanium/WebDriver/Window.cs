using System.Drawing;
using OpenQA.Selenium;

namespace Drelanium
{
    /// <summary>
    ///     Extended implementation of <see cref="IWindow" />
    /// </summary>
    public class Window : IWindow
    {
        /// <summary>
        ///     <inheritdoc cref="Window" />
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Window(IWebDriver driver)
        {
            Driver = driver;
            WindowImplementation = driver.Manage().Window;
        }

        /// <summary>
        ///     <inheritdoc cref="IWindow" />
        /// </summary>
        private IWindow WindowImplementation { get; }

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     <inheritdoc cref="IWindow.Maximize()" />
        /// </summary>
        public void Maximize()
        {
            WindowImplementation.Maximize();
        }

        /// <summary>
        ///     <inheritdoc cref="IWindow.Minimize()" />
        /// </summary>
        public void Minimize()
        {
            WindowImplementation.Minimize();
        }

        /// <summary>
        ///     <inheritdoc cref="IWindow.FullScreen()" />
        /// </summary>
        public void FullScreen()
        {
            WindowImplementation.FullScreen();
        }

        /// <summary>
        ///     <inheritdoc cref="IWindow.Position" />
        /// </summary>
        public Point Position
        {
            get => WindowImplementation.Position;
            set => WindowImplementation.Position = value;
        }

        /// <summary>
        ///     <inheritdoc cref="IWindow.Size" />
        /// </summary>
        public Size Size
        {
            get => WindowImplementation.Size;
            set => WindowImplementation.Size = value;
        }
    }
}