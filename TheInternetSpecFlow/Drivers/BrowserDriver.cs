using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternetSpecFlow.Drivers
{
    public class BrowserDriver : IDisposable
    {
        public readonly IWebDriver webDriver;
        private bool _isDisposed;

        public BrowserDriver()
        {
            webDriver = CreateWebDriver();
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

            webDriver.Quit();
            _isDisposed = true;
        }
    }
}
