using OpenQA.Selenium;
using Xunit.Sdk;

namespace TheInternetSpecFlow.Pages
{
    public class HomeNavPage : GeneralPage
    {
        private readonly HttpClient _client;

        public HomeNavPage(BrowserDriver browser)
            : base(browser, "/")
        {
            _client = new HttpClient();
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
