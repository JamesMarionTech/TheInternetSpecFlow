using OpenQA.Selenium;
using System.Security.Policy;

namespace TheInternetSpecFlow.Pages
{
    public class BasicAuthPage : GeneralPage
    {
        public BasicAuthPage(BrowserDriver browser)
            : base(browser, "/basic_auth/")
        { }

        public void EnterValidCredentials()
        {
            _url = "http://" + "admin" + ":" + "admin" + "@" + _url.Substring(7);
            base.GoToPage();
        }
    }
}
