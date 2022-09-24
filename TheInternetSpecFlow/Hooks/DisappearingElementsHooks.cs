namespace TheInternetSpecFlow.Hooks
{
    [Binding]
    public class DisappearingElementsHooks
    {
        [BeforeFeature("DisappearingElements_Feature")]
        public static void BeforeFeature(BrowserDriver browserDriver)
        {
            var disappearingElementsObject = new DisappearingElementsPage(browserDriver);
            disappearingElementsObject.GoToPage();
        }
    }
}