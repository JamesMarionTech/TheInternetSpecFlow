namespace TheInternetSpecFlow.StepDefinitions
{
    [Binding]
    public class DisappearingElementsStepDefinitions
    {
        private readonly DisappearingElementsPage _disappearingElements;
        private int _initialElementCount;

        public DisappearingElementsStepDefinitions(BrowserDriver browserDriver)
        {
            _disappearingElements = new DisappearingElementsPage(browserDriver);
        }

        // Test 1
        [Given("an initial number of elements")]
        public void GivenAnInitialNumberOfElements()
        {
            _initialElementCount = _disappearingElements.GetNumberOfElements();
        }

        // Test 1
        [Then("there should be a different number of elements within (.*) page refreshes")]
        public void ThereShouldBeADifferentNumberOfElementsWithinSomePageRefreshes(int maxNumRefreshes)
        {
            bool isDifferent = false;
            for(int i = 0; i < maxNumRefreshes; i++)
            {
                _disappearingElements.RefreshPage();
                if(_disappearingElements.GetNumberOfElements() != _initialElementCount)
                {
                    isDifferent = true;
                    break;
                }
            }
            Assert.True(isDifferent, "Number of elements remained the same across " + maxNumRefreshes + " refreshes!");
        }
    }
}