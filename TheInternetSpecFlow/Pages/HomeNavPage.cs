using OpenQA.Selenium;
using System.Security.Policy;

namespace TheInternetSpecFlow.Pages
{
    public class HomeNavPage
    {
        private readonly BrowserDriver _browser;
        private readonly HttpClient _client;

        public HomeNavPage(BrowserDriver browser)
        {
            _browser = browser;
            _client = new HttpClient();
        }
        public void GoToHomePage()
        {
            _browser.webDriver.Navigate().GoToUrl("http://127.0.0.1:7080/");
            Assert.True(_browser.webDriver.Title.Equals("The Internet"));
        }

        public int GetNumberOfLinksOnHomePage()
        {
            var _linksOnPage = _browser.webDriver.FindElements(By.CssSelector("ul a"));
            return _linksOnPage.Count;
        }

        public void HrefExistsOnHomePage(string page)
        {
            var _linksOnPage = _browser.webDriver.FindElements(By.CssSelector("ul a"));
            Assert.Contains(_linksOnPage, a => a.GetAttribute("href") == _browser.webDriver.Url + page);
        }

        public int SendRequestToHref(string page)
        {
            HttpResponseMessage response = _client.GetAsync(_browser.webDriver.Url + page).Result;
            return (int)response.StatusCode;
        }
    }
}
