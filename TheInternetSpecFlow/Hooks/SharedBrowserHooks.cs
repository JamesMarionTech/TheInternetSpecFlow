using BoDi;

namespace TheInternetSpecFlow.Hooks
{
    [Binding]
    public class SharedBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}