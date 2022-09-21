@BrokenImages_Feature
Feature: BrokenImages
Broken images (in this case) are img elements with a src URL that returns a 404 HTTP error code.

On the /broken_images page, 
  /asdf.jpg and /hjkl.jpg return 404, and
  /img/avatar-blank.jpg returns 200

@BrokenImages_Scenario
Scenario: Number of images on the page is 3
    Given the number of image elements on the page
    Then the number of image elements should be 3

@BrokenImages_Scenario
Scenario Outline: The image elements return the intended status codes
    Given an image with a src of <Path> exists on the page
    When I send get an HTTP Response Status Code from the <Path> img src URL
    Then the HTTP Response Status Code for the image should be <Result>
    
Examples:
    | Path                           | Result |
    | /asdf.jpg                      | 404 |
    | /hjkl.jpg                       | 404 |
    | /img/avatar-blank.jpg   | 200 |
