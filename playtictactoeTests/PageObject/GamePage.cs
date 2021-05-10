using OpenQA.Selenium;

namespace playtictactoeTests
{
    public class GamePage
    {
        private readonly IWebDriver _webDriver;

        private static By _amountOfPlayers = By.CssSelector("[class^= swap]");
        private static By _muteButton = By.CssSelector("[class=square]");
        private static By _squareTopLeft = By.CssSelector("[class='square top left']");
        private static By _squareTop = By.CssSelector("[class='square top']");
        private static By _squareTopRight = By.CssSelector("[class='square top right']");
        private static By _squareRight = By.CssSelector("[class='square right']");
        private static By _squareBottomRight = By.CssSelector("[class='square bottom right']");
        private static By _squareBottom = By.CssSelector("[class='square bottom']");
        private static By _squareBottomLeft = By.CssSelector("[class='square bottom left']");
        private static By _squareLeft = By.CssSelector("[class='square left']");
        private static By _square = By.CssSelector("[class='square']");
        private static By _swapPlayers = By.CssSelector("[class=swap]");
        private static By _pressTie = By.CssSelector("[class=ties]");
        private static By _firstPlayerScore = By.CssSelector("p.player1 > span.score");
        private static By _secondPlayerScore = By.CssSelector("p.player2 > span.score");
        private static By _drawScore = By.CssSelector("p.ties > span");
        private static By _restartField = By.CssSelector("[class=restart]");

        public GamePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public GamePage PressTie()
        {
            _webDriver.FindElement(_pressTie).Click();
            return this;
        }

        public GamePage RestartGame()
        {
            _webDriver.FindElement(_restartField).Click();
            return this;
        }

        public GamePage SwapNumberOfPlayers()
        {
            _webDriver.FindElement(_swapPlayers).Click();
            return this;
        }

        public GamePage GoToGamePage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public GamePage MuteSound()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_webDriver;
            js.ExecuteScript("document.querySelector('body > div.mute').click();");
            return this;
        }

        public GamePage SetValueAtTopLeftSquare()
        {
            _webDriver.FindElement(_squareTopLeft).Click();
            return this;
        }

        public GamePage SetValueAtTopSquare()
        {
            _webDriver.FindElement(_squareTop).Click();
            return this;
        }

        public GamePage SetValueAtTopRightSquare()
        {
            _webDriver.FindElement(_squareTopRight).Click();
            return this;
        }

        public GamePage SetValueAtCentralRightSquareRight()
        {
            _webDriver.FindElement(_squareRight).Click();
            return this;
        }

        public GamePage SetValueAtBottomRightSquare()
        {
            _webDriver.FindElement(_squareBottomRight).Click();
            return this;
        }

        public GamePage SetValueAtCentralBottomSquare()
        {
            _webDriver.FindElement(_squareBottom).Click();
            return this;
        }

        public GamePage SetValueAtBottomLeftSquare()
        {
            _webDriver.FindElement(_squareBottomLeft).Click();
            return this;
        }

        public GamePage SetValueAtCentralLeftSquare()
        {
            _webDriver.FindElement(_squareLeft).Click();
            return this;
        }

        public GamePage SetValueAtCentralSquare()
        {
            _webDriver.FindElement(_square).Click();
            return this;
        }

        public string GetFirstPlayerScore() => _webDriver.FindElement(_firstPlayerScore).Text;

        public string GetSecondPlayerScore() => _webDriver.FindElement(_secondPlayerScore).Text;

        public string GetDrawScore() => _webDriver.FindElement(_drawScore).Text;
    }
}