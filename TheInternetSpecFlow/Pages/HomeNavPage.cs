using OpenQA.Selenium;

namespace TheInternetSpecFlow.Pages
{
    public class HomeNavPage
    {
        private readonly BrowserDriver _browser;
        private readonly HttpClient _client;
        private static List<IWebElement> _linksOnPage = new List<IWebElement>();

        public HomeNavPage(BrowserDriver browser)
        {
            _browser = browser;
            _client = new HttpClient();
        }
        public void GoToHomePage()
        {
            _browser.NavigateToURL("http://127.0.0.1:7080/");
            Assert.True(
                _browser
                .GetTitle()
                .Equals("The Internet")
            );
        }

        public void GetLinksOnHomePage()
        {
            if (_linksOnPage.Count == 0)
            {
                _linksOnPage = _browser.FindElementsByCSSSelector("ul a");
            }
        }

        public int GetNumberOfLinksOnHomePage()
        {
            return _linksOnPage.Count;
        }

        public void HrefExistsOnHomePage(string page)
        {
            Assert.Contains(_linksOnPage, a => a.GetAttribute("href") == _browser.GetURL() + page);
        }

        public int SendRequestToHref(string page)
        {
            HttpResponseMessage response = _client.GetAsync(_browser.GetURL() + page).Result;
            return (int)response.StatusCode;
        }
    }
}
