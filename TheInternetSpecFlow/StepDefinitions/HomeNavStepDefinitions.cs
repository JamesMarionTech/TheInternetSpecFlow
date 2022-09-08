namespace TheInternetSpecFlow.StepDefinitions
{
    [Binding]
    public class HomeNavStepDefinitions
    {
        private int _statusCode;
        private readonly HomeNavPage _homeNav;

        public HomeNavStepDefinitions(BrowserDriver browserDriver)
        {
            _homeNav = new HomeNavPage(browserDriver);
        }

        // Both Tests
        [Given("the links on the main section of the home page")]
        public void GivenTheLinksOnTheMainSectionOfTheHomePage()
        {
            _homeNav.GetLinksOnHomePage();
        }

        // Test 1
        [Then("the count of the number of links on the home page should be (.*)")]
        public void TheCountOfTheNumberOfLinksShouldBe(int numLinks)
        {
            _homeNav.GetNumberOfLinksOnHomePage().Should().Be(numLinks);
        }

        // Test 2
        [Given("the (.*) link exists on the main section of the home page")]
        public void GivenThePageLinkExistsOnTheMainSectionOfTheHomePage(string page)
        {
            _homeNav.HrefExistsOnHomePage(page);
        }

        // Test 2
        [When("I send an HTTP Request to the (.*) link")]
        public void WhenISendAnHTTPRequestToTheLinksHref(string page)
        {
            _statusCode = _homeNav.SendRequestToHref(page);
        }

        // Test 2
        [Then("the HTTP Response Status Code should be (.*)")]
        public void ThenTheHTTPResponseStatusCodeShouldBe(int statusCode)
        {
            _statusCode.Should().Be(statusCode);
        }
    }
}