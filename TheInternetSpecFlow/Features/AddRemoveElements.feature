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
    When I click on the Add Element button
    Then the number of elements increases by 1

@AddRemoveElements_Scenario
Scenario: Clicking Delete removes an element from the page
    When I click on the Delete button
    Then the number of elements decreases by 1

@AddRemoveElements_Scenario
Scenario: Clicking Add Element multiple times adds multiple elements to the page
    When I click on the Add Element button 2 times
    Then the number of elements increases by 2

@AddRemoveElements_Scenario
Scenario: Clicking Delete multiple times removes multiple elements from the page
    When I click on the Delete button 2 times
    Then the number of elements decreases by 2