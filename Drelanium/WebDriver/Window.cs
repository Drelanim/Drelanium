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

        /// <summary>
 ///To be added...</summary>
        private IWindow WindowImplementation { get; }


        /// <summary>
        /// The browser, that is represented by an <see cref="IWebDriver" /> instance.
        ///</summary>
        private IWebDriver Driver { get; }

        /// <summary>
 ///To be added...</summary>
        public void Maximize()
        {
            WindowImplementation.Maximize();
        }

        /// <summary>
 ///To be added...</summary>
        public void Minimize()
        {
            WindowImplementation.Minimize();
        }

        /// <summary>
 ///To be added...</summary>
        public void FullScreen()
        {
            WindowImplementation.FullScreen();
        }

        /// <summary>
 ///To be added...</summary>
        public Point Position
        {
            get => WindowImplementation.Position;
            set => WindowImplementation.Position = value;
        }

        /// <summary>
 ///To be added...
 ///</summary>
        public Size Size
        {
            get => WindowImplementation.Size;
            set => WindowImplementation.Size = value;
        }
    }
}