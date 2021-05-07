using OpenQA.Selenium;

namespace playtictactoeTests
{
    public class GamePage
    {
        private readonly IWebDriver _webDriver;

        private static By _amountOfPlayers = By.CssSelector("class^= swap");
        private static By _muteButton = By.CssSelector("class^= mute");
        private static By _mutedButton = By.CssSelector("[class=square]");
        private static By _squareTopLeft = By.CssSelector("[class=square top left]");
        private static By _squareTop = By.CssSelector("[class=square top]");
        private static By _squareTopRight = By.CssSelector("[class=square top right]");
        private static By _squareRight = By.CssSelector("[class=square right]");
        private static By _squareBottomRight = By.CssSelector("[class=square bottom right]");
        private static By _squareBottom = By.CssSelector("[class=square bottom]");
        private static By _squareBottomLeft = By.CssSelector("[class=square bottom left]");
        private static By _squareLeft = By.CssSelector("[class=square left]");
        private static By _square = By.CssSelector("[class=square]");


        public GamePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public GamePage GoToGamePage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public GamePage MuteSound()
        {
            _webDriver.FindElement(_muteButton).Click();
            return this;
        }

        public GamePage MutedSound()
        {
            _webDriver.FindElement(_mutedButton);
            return this;
        }

        public GamePage SetValueAtSquareTopLeft()
        {
            _webDriver.FindElement(_squareTopLeft).Click();
            return this;
        }

        public GamePage SetValueAtSquareTop()
        {
            _webDriver.FindElement(_squareTop).Click();
            return this;
        }

        public GamePage SetValueAtSquareTopRight()
        {
            _webDriver.FindElement(_squareTopRight).Click();
            return this;
        }

        public GamePage SetValueAtSquareRight()
        {
            _webDriver.FindElement(_squareRight).Click();
            return this;
        }

        public GamePage SetValueAtSquareBottomRight()
        {
            _webDriver.FindElement(_squareBottomRight).Click();
            return this;
        }

        public GamePage SetValueAtSquareBottom()
        {
            _webDriver.FindElement(_squareBottom).Click();
            return this;
        }

        public GamePage SetValueAtSquareBottomLeft()
        {
            _webDriver.FindElement(_squareBottomLeft).Click();
            return this;
        }

        public GamePage SetValueAtSquareLeft()
        {
            _webDriver.FindElement(_squareLeft).Click();
            return this;
        }

        public GamePage SetValueAtSquare()
        {
            _webDriver.FindElement(_square).Click();
            return this;
        }
    }
}