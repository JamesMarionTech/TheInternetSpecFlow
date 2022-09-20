@BasicAuth_Feature
Feature: BasicAuth
Basic Authentication prompts cannot be controlled by Selenium.

However, it is possible to enter the credentials through the URL:
http://<username>:<password>@<URL>


@BasicAuth_Scenario
Scenario: Entering valid credentials allows the user to view the page
    When valid credentials are entered
    Then the page displays with the appropriate heading
