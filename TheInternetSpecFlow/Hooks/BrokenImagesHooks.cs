namespace TheInternetSpecFlow.Hooks
{
    [Binding]
    public class BrokenImagesHooks
    {
        [BeforeFeature("BrokenImages_Feature")]
        public static void BeforeFeature(BrowserDriver browserDriver)
        {
            var brokenImagesObject = new BrokenImagesPage(browserDriver);
            brokenImagesObject.GoToPage();
        }
    }
}