using OpenQA.Selenium;

namespace TheInternetSpecFlow.Pages
{
    public class AddRemoveElementsPage : GeneralPage
    {
        public AddRemoveElementsPage(BrowserDriver browser)
            : base(browser, "http://127.0.0.1:7080/add_remove_elements/")
        { }

        public void AddElement()
        {
            var button = _browser.webDriver.FindElements(By.CssSelector(".example > button"));
            if (button.Count != 0)
            {
                button[0].Click();
            }
        }

        public void DeleteElement()
        {
            var button = _browser.webDriver.FindElements(By.CssSelector("#elements > button:first-child"));
            if (button.Count != 0)
            {
                button[0].Click();
            }
        }

        public int GetNumberOfElements()
        {
            return _browser.webDriver.FindElements(By.CssSelector("#elements > button")).Count;
        }
    }
}
