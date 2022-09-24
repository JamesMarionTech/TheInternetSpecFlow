@DisappearingElements_Feature
Feature: DisappearingElements
A page with between 4 to 5 list items.

Sometimes, the 5th element (Gallery) will not appear on page load.

@DisappearingElements_Scenario
Scenario: Refreshing the page enough times will achieve a different number of elements
    Given an initial number of elements
    Then there should be a different number of elements within 10 page refreshes
