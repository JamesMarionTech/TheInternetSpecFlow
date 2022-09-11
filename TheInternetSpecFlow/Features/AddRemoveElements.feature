@AddRemoveElements_Feature
Feature: AddRemoveElements
Buttons to add and remove elements from the page.
The Add Element button creates Delete buttons, which remove themselves.

The JavaScript to obtain the Add Element button:
document.querySelector(".example > button")

The JavaScript to obtain the first Delete button:
document.querySelector("#elements > button:first-child")

@AddRemoveElements_Scenario
Scenario: Clicking Add Element adds an element to the page
    When the Add Element button is clicked
    Then the number of elements should be 1

@AddRemoveElements_Scenario
Scenario: Clicking Delete removes an element from the page
    Given an element was added to the page
    When the Delete button is clicked
    Then the number of elements should be 0

@AddRemoveElements_Scenario
Scenario: Clicking Add Element multiple times adds multiple elements to the page
    When the Add Element button is clicked 2 times
    Then the number of elements should be 2

@AddRemoveElements_Scenario
Scenario: Clicking Delete multiple times removes multiple elements from the page
    Given 2 elements were added to the page
    When the Delete buttons are clicked 2 times
    Then the number of elements should be 0