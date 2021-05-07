using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace playtictactoeTests
{
    class SoundTests
    {
        private IWebDriver _webDriver;
        private GamePage _gamePage;
        private VisibilityElement _visibilityElement;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();

            _visibilityElement = new VisibilityElement();

            _gamePage = new GamePage(_webDriver);
            _gamePage.GoToGamePage();
        }

        [Test]
        public void Test()
        {
            //_gamePage.MuteSound();

            Assert.That(_visibilityElement.existsElement());
        }
    }
}
