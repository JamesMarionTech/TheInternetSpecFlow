namespace TheInternetSpecFlow.Hooks
{
    [Binding]
    public class AddRemoveElementsHooks
    {
        [BeforeFeature("AddRemoveElements_Feature")]
        public static void BeforeFeature(BrowserDriver browserDriver)
        {
            var addRemoveElementsPage = new AddRemoveElementsPage(browserDriver);
            addRemoveElementsPage.GoToPage();
        }
        [BeforeScenario("AddRemoveElements_Scenario")]
        public static void BeforeScenario(BrowserDriver browserDriver)
        {
            var addRemoveElementsPage = new AddRemoveElementsPage(browserDriver);
            while(addRemoveElementsPage.GetNumberOfElements() > 0)
            {
                addRemoveElementsPage.DeleteElement();
            }
        }
    }
}