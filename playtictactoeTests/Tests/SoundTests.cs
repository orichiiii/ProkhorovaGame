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
        private ConstMethods _constMethods;

        [SetUp]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _webDriver = new ChromeDriver();

            _gamePage = new GamePage(_webDriver);
        }

        [Test]
        public void Test()
        {
            var expectedResult = true;

            _gamePage.GoToGamePage()
                .MuteSound();

            Assert.AreEqual(expectedResult, _constMethods.VisibilityOfElement(By.CssSelector("[d ^= 'M67']")));
        }
    }
}
