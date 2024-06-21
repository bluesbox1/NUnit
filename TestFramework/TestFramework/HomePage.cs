using OpenQA.Selenium;

namespace TestFramework.PageObjects
{
    public class HomePage
    {
        private readonly WebActions _webActions;
        private readonly By _searchBox = By.Name("q");
        private readonly By _searchButton = By.Name("btnK");

        public HomePage(WebActions webActions)
        {
            _webActions = webActions;
        }

        public void OpenHomePage()
        {
            _webActions.NavigateToUrl("https://www.google.com");
        }

        public void EnterSearchText(string searchText)
        {
            _webActions.EnterText(_searchBox, searchText);
        }

        public void ClickSearchButton()
        {
            _webActions.ClickElement(_searchButton);
        }

        public bool IsSearchBoxDisplayed()
        {
            return _webActions.IsElementDisplayed(_searchBox);
        }
    }
}
