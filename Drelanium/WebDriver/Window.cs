using System.Drawing;
using OpenQA.Selenium;


namespace Drelanium.WebDriver
{

    public class Window : IWindow
    {

        /// <param name="driver">The used WebDriver instance.</param>
        public Window(IWebDriver driver)
        {
            Driver = driver;
            WindowImplementation = driver.Manage().Window;
        }

        private IWindow WindowImplementation { get; }
        private IWebDriver Driver { get; }

        public void Maximize()
        {
            WindowImplementation.Maximize();
        }

        public void Minimize()
        {
            WindowImplementation.Minimize();
        }

        public void FullScreen()
        {
            WindowImplementation.FullScreen();
        }

        public Point Position
        {
            get => WindowImplementation.Position;
            set => WindowImplementation.Position = value;
        }

        public Size Size
        {
            get => WindowImplementation.Size;
            set => WindowImplementation.Size = value;
        }

    }

}