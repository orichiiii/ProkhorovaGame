using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace playtictactoeTests
{
    public class SoundTests
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
        }

        [Test]
        public void MuteSound()
        {
            var expectedResult = true;

            _gamePage.GoToGamePage()
                .MuteSound();

            Assert.AreEqual(expectedResult, _constMethods.InvisibilityOfElement(By.CssSelector("[d^= 'M67']")));
        }

        [Test]
        public void UnMuteSound()
        {
            var expectedResult = true;

            _gamePage.GoToGamePage()
                .MuteSound();
            Thread.Sleep(3000);
            _gamePage.MuteSound();

            Assert.AreEqual(expectedResult, _constMethods.VisibilityOfElement(By.CssSelector("[d^=M67]")));
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}
