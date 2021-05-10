using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace playtictactoeTests
{
    public class ConstMethods
    {
        private readonly IWebDriver _webDriver;
        private WebDriverWait _wait;

        public ConstMethods(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public bool InvisibilityOfElement(By locator)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(4));

           try
           {
                _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
           }
            catch (TimeoutException)
           {
                return false;
           }
           return true;
        }

        public bool VisibilityOfElement(By locator)
        {
            _wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(4));

            try
            {
                _wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (TimeoutException)
            {
                return false;
            }
            return true;
        }
    }
}
