namespace TheInternetSpecFlow.StepDefinitions
{
    [Binding]
    public class BasicAuthStepDefinitions
    {
        private readonly BasicAuthPage _basicAuth;

        public BasicAuthStepDefinitions(BrowserDriver browserDriver)
        {
            _basicAuth = new BasicAuthPage(browserDriver);
        }

        // Test 1
        [When("valid credentials are entered")]
        public void ValidCredentialsAreEntered()
        {
            _basicAuth.EnterValidCredentials();
        }

        // Test 1
        [Then("the page displays with the appropriate heading")]
        public void ThePageDisplaysWithTheAppropriateHeading()
        {
            _basicAuth.GetHeadingText().Should().Be("Basic Auth");
        }
    }
}