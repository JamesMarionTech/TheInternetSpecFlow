@HomeNav_Feature
Feature: HomeNav
Navigation links to the rest of the website that are on the home page

The JavaScript to obtain the links:
document.querySelectorAll("ul a").forEach((a) => { console.log(a.href) })

@HomeNav_Scenario
Scenario: Number of links on home page is 44
    Given the links on the main section of the home page
    Then the count of the number of links on the home page should be 44

@HomeNav_Scenario
Scenario Outline: Linked pages on the home page exist
    Given the links on the main section of the home page
    Given the <page> link exists on the main section of the home page
    When I send an HTTP Request to the <page> link
    Then the HTTP Response Status Code should be <Result>

Examples:
    | page                                                    | Result |
    | abtest                | 200    |
    | add_remove_elements/  | 200    |
    | basic_auth            | 401    |
    | broken_images         | 200    |
    | challenging_dom       | 200    |
    | checkboxes            | 200    |
    | context_menu          | 200    |
    | digest_auth           | 401    |
    | disappearing_elements | 200    |
    | drag_and_drop         | 200    |
    | dropdown              | 200    |
    | dynamic_content       | 200    |
    | dynamic_controls      | 200    |
    | dynamic_loading       | 200    |
    | entry_ad              | 200    |
    | exit_intent           | 200    |
    | download              | 200    |
    | upload                | 200    |
    | floating_menu         | 200    |
    | forgot_password       | 200    |
    | login                 | 200    |
    | frames                | 200    |
    | geolocation           | 200    |
    | horizontal_slider     | 200    |
    | hovers                | 200    |
    | infinite_scroll       | 200    |
    | inputs                | 200    |
    | jqueryui/menu         | 200    |
    | javascript_alerts     | 200    |
    | javascript_error      | 200    |
    | key_presses           | 200    |
    | large                 | 200    |
    | windows               | 200    |
    | nested_frames         | 200    |
    | notification_message  | 200    |
    | redirector            | 200    |
    | download_secure       | 401    |
    | shadowdom             | 200    |
    | shifting_content      | 200    |
    | slow                  | 200    |
    | tables                | 200    |
    | status_codes          | 200    |
    | typos                 | 200    |
    | tinymce               | 200    |