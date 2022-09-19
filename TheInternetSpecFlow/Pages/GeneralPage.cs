namespace TheInternetSpecFlow.Pages
{
    public class GeneralPage
    {
        protected readonly BrowserDriver _browser;
        private readonly string _url;
        public GeneralPage(BrowserDriver browser, string url)
        {
            _browser = browser;
            _url = url;
        }
        public void GoToPage()
        {
            _browser.webDriver.Navigate().GoToUrl(_url);
        }
    }
}
