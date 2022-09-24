using OpenQA.Selenium;

namespace TheInternetSpecFlow.Pages
{
    public class DisappearingElementsPage : GeneralPage
    {
        public DisappearingElementsPage(BrowserDriver browser)
            : base(browser, "/disappearing_elements")
        { }

        public int GetNumberOfElements()
        {
            return 
                _browser.webDriver
                .FindElements(By.CssSelector(".example li"))
                .Count();
        }

        public void RefreshPage()
        {
            _browser.webDriver.Navigate().Refresh();
        }
    }
}
