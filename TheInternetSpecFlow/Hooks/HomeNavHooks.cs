namespace TheInternetSpecFlow.Hooks
{
    [Binding]
    public class HomeNavHooks
    {
        [BeforeFeature("HomeNav_Feature")]
        public static void BeforeFeature(BrowserDriver browserDriver)
        {
            var homeNavObject = new HomeNavPage(browserDriver);
            homeNavObject.GoToPage();
        }
    }
}