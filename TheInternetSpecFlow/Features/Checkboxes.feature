@Checkboxes_Feature
Feature: Checkboxes
A page with two checkboxes that gain an attribute named "checked" using JavaScript.

The second checkbox is checked by default.

@Checkboxes_Scenario
Scenario Outline: Clicking all checkboxes toggles their checked attributes
    When checkbox <num> is clicked
    Then checkbox <num>'s checked state should be <state>

Examples:
    | num | state           |
    | 1     | true       |
    | 2     | false   |

@Checkboxes_Scenario
Scenario Outline: Clicking all checkboxes twice keeps their original checked attributes
    When checkbox <num> is clicked twice
    Then checkbox <num>'s checked state should be <state>

Examples:
    | num | state    |
    | 1     | false     |
    | 2     | true      |