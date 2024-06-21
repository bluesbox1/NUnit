using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestFramework.PageObjects;
using Microsoft.Extensions.DependencyInjection;

namespace TestFramework
{
    public class GoogleHomePageTest
    {
        private IWebDriver _driver;
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();

            // Configure dependency injection
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton(_driver);
            serviceCollection.AddSingleton<WebActions>();
            serviceCollection.AddTransient<HomePage>();

            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        [Test]
        public void GoogleHomePageIsDisplayed()
        {
            // Resolve the HomePage object from the service provider
            var homePage = _serviceProvider.GetService<HomePage>();

            // Use the HomePage object to perform actions and assertions
            homePage.OpenHomePage();
            Assert.That(homePage.IsSearchBoxDisplayed(), "The Google home page is not displayed.");
        }

        [TearDown]
        public void TearDown()
        {
            // Close the browser
            _driver.Quit();

            // Dispose the service provider
            _serviceProvider.Dispose();
        }
    }
}
