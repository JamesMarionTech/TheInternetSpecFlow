using OpenQA.Selenium;
using Xunit.Sdk;

namespace TheInternetSpecFlow.Pages
{
    public class BrokenImagesPage : GeneralPage
    {
        private readonly HttpClient _client;

        public BrokenImagesPage(BrowserDriver browser)
            : base(browser, "/broken_images")
        {
            _client = new HttpClient();
        }

        public int GetNumberOfImagesOnPage()
        {
            var _linksOnPage = _browser.webDriver.FindElements(By.CssSelector(".example > img"));
            return _linksOnPage.Count;
        }

        public void ImageExistsOnPage(string src)
        {
            string baseURL = new Uri(_browser.webDriver.Url).GetLeftPart(UriPartial.Authority);

            var _imgsOnPage = _browser.webDriver.FindElements(By.CssSelector(".example > img"));
            Assert.Contains(_imgsOnPage, img => img.GetAttribute("src") == baseURL + src);
        }

        public int GetHTTPCodeFromURL(string src)
        {
            string baseURL = new Uri(_browser.webDriver.Url).GetLeftPart(UriPartial.Authority);

            HttpResponseMessage response = _client.GetAsync(baseURL + src).Result;
            return (int)response.StatusCode;
        }
    }
}
