@AddRemoveElements_Feature
Feature: AddRemoveElements
Buttons to add and remove elements from the page.
The Add Element button creates Delete buttons, which remove themselves.

The JavaScript to obtain the Add Element button:
document.querySelector(".example > button")

The JavaScript to obtain the first Delete button:
document.querySelector("#elements > button:first-child")

@AddRemoveElements_Scenario
Scenario Outline: Clicking Add and then Delete various amounts of times gives a certain number of elements on the page
    Given <NumToAdd> elements were added to the page
    When the Delete buttons are clicked <NumToDelete> times
    Then the number of elements should be <NumRemaining>

Examples:
    | NumToAdd | NumToDelete | NumRemaining |
    | 1               | 0                  | 1                     |
    | 2               | 0                  | 2                     |
    | 2               | 1                  | 1                     |
    | 5               | 0                  | 5                     |
    | 3               | 2                  | 1                     |
    | 5               | 5                  | 0                     |