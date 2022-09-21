namespace TheInternetSpecFlow.StepDefinitions
{
    [Binding]
    public class CheckboxesStepDefinitions
    {
        private readonly CheckboxesPage _checkboxes;

        public CheckboxesStepDefinitions(BrowserDriver browserDriver)
        {
            _checkboxes = new CheckboxesPage(browserDriver);
        }

        // Test 1
        [When("checkbox (.*) is clicked")]
        public void WhenACertainCheckboxIsClicked(int checkboxNum)
        {
            _checkboxes.ToggleCheckbox(checkboxNum);
        }

        // Test 2
        [When("checkbox (.*) is clicked twice")]
        public void WhenACertainCheckboxIsClickedTwice(int checkboxNum)
        {
            _checkboxes.ToggleCheckbox(checkboxNum);
            _checkboxes.ToggleCheckbox(checkboxNum);
        }

        // Both Tests
        [Then("checkbox (.*)'s checked state should be (.*)")]
        public void ThenTheCheckboxCheckedStateShouldBe(int checkboxNum, bool expectedCheckedStatus)
        {
            Assert.Equal(expectedCheckedStatus, _checkboxes.GetCheckboxState(checkboxNum));
        }
    }
}