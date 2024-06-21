using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestFramework
{
    public class WebActions
    {
        private readonly IWebDriver _driver;

        public WebActions(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateToUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClickElement(By locator)
        {
            _driver.FindElement(locator).Click();
        }

        public void EnterText(By locator, string text)
        {
            _driver.FindElement(locator).SendKeys(text);
        }

        public string GetElementText(By locator)
        {
            return _driver.FindElement(locator).Text;
        }

        public bool IsElementDisplayed(By locator)
        {
            try
            {
                return _driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
