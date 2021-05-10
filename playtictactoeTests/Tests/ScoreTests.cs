using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace playtictactoeTests
{
    class ScoreTests
    {
        private IWebDriver _webDriver;
        private GamePage _gamePage;
        private ConstMethods _constMethods;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _constMethods = new ConstMethods(_webDriver);

            _gamePage = new GamePage(_webDriver);
            _gamePage.GoToGamePage();
        }

        [Test]
        public void FirstPlayerScore()
        {
            _gamePage.SwapNumberOfPlayers()
            .SetValueAtCentralSquare()
                .SetValueAtCentralRightSquareRight()
                .SetValueAtCentralBottomSquare()
                .SetValueAtBottomRightSquare()
                .SetValueAtTopSquare();
            Thread.Sleep(1000);

            Assert.AreEqual("1", _gamePage.GetFirstPlayerScore());
            Assert.AreEqual("0", _gamePage.GetSecondPlayerScore());
        }

        [Test]
        public void SecondPlayerScore()
        {
            _gamePage.SwapNumberOfPlayers()
                .SetValueAtTopRightSquare()
                .SetValueAtCentralSquare()
                .SetValueAtTopSquare()
                .SetValueAtCentralLeftSquare()
                .SetValueAtCentralBottomSquare()
                .SetValueAtCentralRightSquareRight();
            Thread.Sleep(1000);

            Assert.AreEqual("0", _gamePage.GetFirstPlayerScore());
            Assert.AreEqual("1", _gamePage.GetSecondPlayerScore());
        }

        [Test]
        public void GameWithDraw()
        {
            _gamePage.SwapNumberOfPlayers()
                .SetValueAtCentralSquare()
                .SetValueAtBottomRightSquare()
                .SetValueAtCentralBottomSquare()
                .SetValueAtCentralLeftSquare()
                .SetValueAtBottomLeftSquare()
                .SetValueAtTopRightSquare()
                .SetValueAtCentralRightSquareRight()
                .SetValueAtTopSquare()
                .SetValueAtTopLeftSquare();
            Thread.Sleep(1000);

            Assert.AreEqual("1", _gamePage.GetDrawScore());
            Assert.AreEqual("0", _gamePage.GetSecondPlayerScore());
            Assert.AreEqual("0", _gamePage.GetFirstPlayerScore());
        }

        [Test]
        public void RestartGame()
        {
            _gamePage.SwapNumberOfPlayers()
                .SetValueAtCentralSquare()
                .SetValueAtBottomRightSquare()
                .SetValueAtCentralBottomSquare()
                .SetValueAtCentralLeftSquare()
                .SetValueAtBottomLeftSquare()
                .SetValueAtTopRightSquare()
                .SetValueAtCentralRightSquareRight()
                .SetValueAtTopSquare()
                .SetValueAtTopLeftSquare();
            Thread.Sleep(1000);
            _gamePage.RestartGame()
                .SetValueAtBottomLeftSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
