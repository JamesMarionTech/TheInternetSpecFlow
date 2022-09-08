using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternetSpecFlow.Drivers
{
    public class BrowserDriver : IDisposable
    {
        private readonly IWebDriver _webDriver;
        private bool _isDisposed;

        public BrowserDriver()
        {
            _webDriver = CreateWebDriver();
        }

        private IWebDriver CreateWebDriver()
        {
            //We use the Chrome browser
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            var chromeOptions = new ChromeOptions();
            var chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions);
            return chromeDriver;
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            _webDriver.Quit();
            _isDisposed = true;
        }

        public string GetTitle()
        {
            return _webDriver.Title;
        }

        public void NavigateToURL(string URL)
        {
            _webDriver.Navigate().GoToUrl(URL);
        }

        public string GetURL()
        {
            return _webDriver.Url;
        }

        public List<IWebElement> FindElementsByCSSSelector(string selector)
        {
            return _webDriver.FindElements(By.CssSelector(selector)).ToList();
        }
    }
}
