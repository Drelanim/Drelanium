using OpenQA.Selenium;
using Serilog.Core;

// ReSharper disable InconsistentNaming
namespace Drelanium
{
    /// <summary>
    ///     ...Description to be added...
    /// </summary>
    public class MouseMoveFollower
    {
        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private const string pictureInBase64 =
            "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABQAAAAeCAQAAACGG/bgAAAAAmJLR0QA" +
            "/4ePzL8AAAAJcEhZcwAAHsYAAB7GAZEt8iwAAAAHdElNRQfgAwgMIwdxU/i7AAABZklEQVQ4y43TsU" +
            "4UURSH8W+XmYwkS2I09CRKpKGhsvIJjG9giQmliHFZlkUIGnEF7KTiCagpsYHWhoTQaiUUxLixYZb5" +
            "KAAZZhbunu7O/PKfe+fcA+/pqwb4DuximEqXhT4iI8dMpBWEsWsuGYdpZFttiLSSgTvhZ1W/SvfO1C" +
            "vYdV1kPghV68a30zzUWZH5pBqEui7dnqlFmLoq0gxC1XfGZdoLal2kea8ahLoqKXNAJQBT2yJzwUTV" +
            "t0bS6ANqy1gaVCEq/oVTtjji4hQVhhnlYBH4WIJV9vlkXLm+10R8oJb79Jl1j9UdazJRGpkrmNkSF9" +
            "SOz2T71s7MSIfD2lmmfjGSRz3hK8l4w1P+bah/HJLN0sys2JSMZQB+jKo6KSc8vLlLn5ikzF4268Wg" +
            "2+pPOWW6ONcpr3PrXy9VfS473M/D7H+TLmrqsXtOGctvxvMv2oVNP+Av0uHbzbxyJaywyUjx8TlnPY" +
            "2YxqkDdAAAAABJRU5ErkJggg==";

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private const string SeleniumMouseMoveFollowerID = "SeleniumMouseMoveFollower";

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        private const string MouseMoveFollowerFunctionName = "MouseMoveFollower";

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        /// <param name="driver">The browser, that is represented by an <see cref="IWebDriver" /> instance.</param>
        public MouseMoveFollower(IWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public bool IsTurnedON => Driver.Search().HasElement(By.Id(SeleniumMouseMoveFollowerID));

        /// <summary>
        ///     <inheritdoc cref="IWebDriver" />
        /// </summary>
        private IWebDriver Driver { get; }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void TurnOFF(Logger logger = null)
        {
            if (!IsTurnedON)
            {
                return;
            }

            logger?.Information("Turning off the MouseMoveFollower feature.");

            Driver.RemoveEventListener(EventType.mousemove, MouseMoveFollowerFunctionName);

            Driver.FindElement(By.Id(SeleniumMouseMoveFollowerID)).Remove();
        }

        /// <summary>
        ///     ...Description to be added...
        /// </summary>
        public void TurnON(Logger logger = null)
        {
            if (IsTurnedON)
            {
                return;
            }

            logger?.Information("Turning on the MouseMoveFollower feature.");

            var seleniumMouseMoveFollower =
                Driver.Create().CreateElement(SeleniumMouseMoveFollowerID, "img", Driver.Body());

            Driver.Create().CreateFunction(MouseMoveFollowerFunctionName, "(event)",
                $"{{{SeleniumMouseMoveFollowerID}.style.left = event.pageX + 'px'; {SeleniumMouseMoveFollowerID}.style.top = event.pageY + 'px';}}.");

            Driver.AddEventListener(EventType.mousemove, MouseMoveFollowerFunctionName);

            seleniumMouseMoveFollower.Attributes().ID = "SeleniumMouseMoveFollower";
            seleniumMouseMoveFollower.Attributes().Style = "position: absolute; z-index: 65535; pointer-events: none;";
            seleniumMouseMoveFollower.Attributes().Src = pictureInBase64;
        }
    }
}