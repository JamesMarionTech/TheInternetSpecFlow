namespace TheInternetSpecFlow.StepDefinitions
{
    [Binding]
    public class AddRemoveElementsStepDefinitions
    {
        private readonly AddRemoveElementsPage _addRemoveElements;

        public AddRemoveElementsStepDefinitions(BrowserDriver browserDriver)
        {
            _addRemoveElements = new AddRemoveElementsPage(browserDriver);
        }

        // Test 1
        [When("the Add Element button is clicked")]
        public void WhenTheAddElementButtonIsClicked()
        {
            _addRemoveElements.AddElement();
        }

        // Test 1
        [Then("the number of elements should be 1")]
        public void ThenTheNumberOfElementsShouldBe1()
        {
            _addRemoveElements.GetNumberOfElements().Should().Be(1);
        }

        // Test 3
        [When("the Add Element button is clicked 2 times")]
        public void WhenTheAddElementButtonIsClicked2Times()
        {
            _addRemoveElements.AddElement();
            _addRemoveElements.AddElement();
        }

        // Test 3
        [Then("the number of elements should be 2")]
        public void ThenTheNumberOfElementsShouldBe2()
        {
            _addRemoveElements.GetNumberOfElements().Should().Be(2);
        }

        // Test 2
        [Given("an element was added to the page")]
        public void GivenAnElementWasAddedToThePage()
        {
            _addRemoveElements.AddElement();
        }

        // Test 2
        [When("the Delete button is clicked")]
        public void WhenTheDeleteButtonIsClicked()
        {
            _addRemoveElements.DeleteElement();
        }

        // Test 2
        [Given("2 elements were added to the page")]
        public void Given2ElementsWereAddedToThePage()
        {
            _addRemoveElements.AddElement();
            _addRemoveElements.AddElement();
        }

        // Test 2
        [When("the Delete buttons are clicked 2 times")]
        public void WhenTheDeleteButtonsAreClicked2Times()
        {
            _addRemoveElements.DeleteElement();
            _addRemoveElements.DeleteElement();
        }

        // Tests 2 and 4
        [Then("the number of elements should be 0")]
        public void ThenTheHTTPResponseStatusCodeShouldBe()
        {
            _addRemoveElements.GetNumberOfElements().Should().Be(0);
        }
    }
}