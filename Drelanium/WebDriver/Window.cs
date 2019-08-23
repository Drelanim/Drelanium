using System.Drawing;
using OpenQA.Selenium;

namespace Drelanium.WebDriver
{
    /// <summary>
    ///To be added...</summary>
    public class Window : IWindow
    {
        /// <summary>
        ///To be added...</summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public Window(IWebDriver driver)
        {
            Driver = driver;
            WindowImplementation = driver.Manage().Window;
        }


        /// <inheritdoc cref="IWindow"/>
        private IWindow WindowImplementation { get; }


        /// <inheritdoc cref="IWebDriver"/>
        private IWebDriver Driver { get; }

        /// <inheritdoc></inheritdoc>
        public void Maximize()
        {
            WindowImplementation.Maximize();
        }

        /// <inheritdoc></inheritdoc>
        public void Minimize()
        {
            WindowImplementation.Minimize();
        }

        /// <inheritdoc></inheritdoc>
        public void FullScreen()
        {
            WindowImplementation.FullScreen();
        }

        /// <inheritdoc></inheritdoc>
        public Point Position
        {
            get => WindowImplementation.Position;
            set => WindowImplementation.Position = value;
        }

        /// <inheritdoc></inheritdoc>
        public Size Size
        {
            get => WindowImplementation.Size;
            set => WindowImplementation.Size = value;
        }
    }
}