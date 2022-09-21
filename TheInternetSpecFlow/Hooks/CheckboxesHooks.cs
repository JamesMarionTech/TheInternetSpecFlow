namespace TheInternetSpecFlow.Hooks
{
    [Binding]
    public class CheckboxesHooks
    {
        [BeforeFeature("Checkboxes_Feature")]
        public static void BeforeFeature(BrowserDriver browserDriver)
        {
            var checkboxesPage = new CheckboxesPage(browserDriver);
            checkboxesPage.GoToPage();
        }
        [BeforeScenario("Checkboxes_Scenario")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var checkboxesPage = new CheckboxesPage(browserDriver);
            checkboxesPage.ResetAllCheckboxes();
        }
    }
}