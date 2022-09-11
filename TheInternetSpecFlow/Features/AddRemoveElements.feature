@AddRemoveElements_Feature
Feature: AddRemoveElements
Navigation links to the rest of the website that are on the home page

The JavaScript to obtain the links:
document.querySelectorAll("ul a").forEach((a) => { console.log(a.href) })

@AddRemoveElements_Scenario
Scenario: Clicking Add Element adds an element to the page
    When I click on the Add Element button
    Then the number of elements increases by 1
