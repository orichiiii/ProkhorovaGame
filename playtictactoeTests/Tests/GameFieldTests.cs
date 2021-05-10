using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace playtictactoeTests
{
    class GameFieldTests
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
        public void ClickOn_Central_Square()
        {
            _gamePage.SetValueAtCentralSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_CentralLeft_Square()
        {
            _gamePage.SetValueAtCentralLeftSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_BottomLeft_Square()
        {
            _gamePage.SetValueAtBottomLeftSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_CentralBottom_Square()
        {
            _gamePage.SetValueAtCentralBottomSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_BottomRight_Square()
        {
            _gamePage.SetValueAtBottomRightSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_CentralRight_Square()
        {
            _gamePage.SetValueAtCentralRightSquareRight();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_TopRight_Square()
        {
            _gamePage.SetValueAtTopRightSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_TopCentral_Square()
        {
            _gamePage.SetValueAtTopSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ClickOn_TopLeft_Square()
        {
            _gamePage.SetValueAtTopLeftSquare();

            Assert.That(_constMethods.VisibilityOfElement(By.CssSelector("[class = x]")));
        }

        [Test]
        public void ChangeNumberOfPlayers()
        {
            _gamePage.SwapNumberOfPlayers();

            Assert.That(_constMethods.VisibilityOfElement(By.ClassName("p2")));
        }

        [Test]
        public void ChangeNumberOfPlayer()
        {
            _gamePage.PressTie();

            Assert.That(_constMethods.VisibilityOfElement(By.ClassName("p2")));
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
