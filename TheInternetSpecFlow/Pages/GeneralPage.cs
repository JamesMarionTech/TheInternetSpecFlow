using OpenQA.Selenium;

namespace TheInternetSpecFlow.Pages
{
    public class GeneralPage
    {
        protected readonly BrowserDriver _browser;
        protected string _url;
        public GeneralPage(BrowserDriver browser, string path)
        {
            _browser = browser;
            _url = "http://127.0.0.1:7080" + path;
        }
        public virtual void GoToPage()
        {
            _browser.webDriver.Navigate().GoToUrl(_url);
        }

        public string GetHeadingText()
        {
            return _browser.webDriver.FindElement(By.TagName("h3")).Text;
        }
    }
}
