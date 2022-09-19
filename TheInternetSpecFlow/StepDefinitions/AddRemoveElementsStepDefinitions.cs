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
        [Given("(.*) elements were added to the page")]
        public void GivenSomeAmountOfElementsWereAddedToThePage(int numElementsToAdd)
        {
            for (int i = 0; i < numElementsToAdd; i++)
            {
                _addRemoveElements.AddElement();
            }
        }

        // Test 1
        [When("the Delete buttons are clicked (.*) times")]
        public void WhenTheDeleteButtonsAreClickedSomeAmountOfTimes(int numElementsToDelete)
        {
            for (int i = 0; i < numElementsToDelete; i++)
            {
                _addRemoveElements.DeleteElement();
            }
        }

        // Test 1
        [Then("the number of elements should be (.*)")]
        public void ThenTheNumberOfElementsShouldBe(int numElementsRemaining)
        {
            _addRemoveElements.GetNumberOfElements().Should().Be(numElementsRemaining);
        }
    }
}