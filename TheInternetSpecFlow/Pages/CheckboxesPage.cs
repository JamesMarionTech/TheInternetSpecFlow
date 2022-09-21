using OpenQA.Selenium;

namespace TheInternetSpecFlow.Pages
{
    public class CheckboxesPage : GeneralPage
    {
        public CheckboxesPage(BrowserDriver browser)
            : base(browser, "/checkboxes")
        { }

        public void ResetAllCheckboxes()
        {
            var checkboxes = _browser.webDriver.FindElements(By.CssSelector(".example input[type='checkbox']"));
            if (checkboxes.Count > 0)
            {
                if (checkboxes[0].Selected)
                {
                    checkboxes[0].Click();
                }
                if (!checkboxes[1].Selected)
                {
                    checkboxes[1].Click();
                }
            }
        }

        public void ToggleCheckbox(int checkboxNum)
        {
            var checkboxes = _browser.webDriver.FindElements(By.CssSelector(".example input[type='checkbox']"));
            if (checkboxes.Count > 0)
            {
                checkboxes[checkboxNum - 1].Click();
            }
        }

        public bool? GetCheckboxState(int checkboxNum)
        {
            var checkboxes = _browser.webDriver.FindElements(By.CssSelector(".example input[type='checkbox']"));
            if (checkboxes.Count > 0)
            {
                return checkboxes[checkboxNum - 1].Selected;
            }
            else
            {
                return null;
            }
        }
    }
}
