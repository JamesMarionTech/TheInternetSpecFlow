namespace TheInternetSpecFlow.StepDefinitions
{
    [Binding]
    public class BrokenImagesStepDefinitions
    {
        private int _statusCode;
        private int _numImages;
        private readonly BrokenImagesPage _brokenImages;

        public BrokenImagesStepDefinitions(BrowserDriver browserDriver)
        {
            _brokenImages = new BrokenImagesPage(browserDriver);
        }

        // Test 1
        [Given("the number of image elements on the page")]
        public void GivenTheNumberOfImageElementsOnThePage()
        {
            _numImages = _brokenImages.GetNumberOfImagesOnPage();
        }

        // Test 1
        [Then("the number of image elements should be (.*)")]
        public void TheNumberOfImagesShouldBe(int numImages)
        {
            _numImages.Should().Be(numImages);
        }

        // Test 2
        [Given("an image with a src of (.*) exists on the page")]
        public void GivenAnImageWithASrcExistsOnThePage(string src)
        {
            _brokenImages.ImageExistsOnPage(src);
        }

        // Test 2
        [When("I send get an HTTP Response Status Code from the (.*) img src URL")]
        public void WhenIGetAnHTTPResponseStatusCodeFromTheImageSrcURL(string src)
        {
            _statusCode = _brokenImages.GetHTTPCodeFromURL(src);
        }

        // Test 2
        [Then("the HTTP Response Status Code for the image should be (.*)")]
        public void ThenTheHTTPResponseStatusCodeForTheImageShouldBe(int statusCode)
        {
            _statusCode.Should().Be(statusCode);
        }
    }
}