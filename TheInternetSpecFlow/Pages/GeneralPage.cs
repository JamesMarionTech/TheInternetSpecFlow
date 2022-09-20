namespace TheInternetSpecFlow.Pages
{
    public class GeneralPage
    {
        protected readonly BrowserDriver _browser;
        private readonly string _url;
        public GeneralPage(BrowserDriver browser, string path)
        {
            _browser = browser;
            _url = "http://127.0.0.1:7080" + path;
        }
        public void GoToPage()
        {
            _browser.webDriver.Navigate().GoToUrl(_url);
        }
    }
}
