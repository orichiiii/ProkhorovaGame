using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace playtictactoeTests
{
    class VisibilityElement
    {
        private readonly IWebDriver _webDriver;
        public VisibilityElement()
        {

        }

        public bool existsElement()
        {
            try
            {
                _webDriver.FindElement(By.CssSelector("[d= 'M67.41, 34.095l - 4.243, 4.239c6.43, 6.432, 6.43, 16.896, 0, 23.324L67.41, 65.9C76.179, 57.129, 76.179, 42.864, 67.41, 34.095z']"));
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }
    }
}
