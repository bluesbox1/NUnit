using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace TestFramework
{
    
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + @"\drivers\");

        }

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://www.browserstack.com/");

            //Assert.IsTrue(driver.FindElement(By.Id("logo")).Displayed);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
