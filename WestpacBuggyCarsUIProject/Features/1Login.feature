Feature: 1Login
  As a User
  I want to Login
  So that I can rank my cars in Buggy car Website

@prod
Scenario Outline: User login to buggy cars website
    Given User navigates to Buggy car with '<userName>' And '<password>'
    When User Clicks on Login button
    Then User should able to see Home Page
 Examples:
    | Scenario   | userName | password |
    | ValidLogin |  bugcrgub|Buggub@123|

 @prod
 Scenario Outline: User can not login to buggy cars website with invalid credentials
    Given User navigates to Buggy car with '<userName>' And '<password>'
    When User Clicks on Login button
    Then User should able to see error message '<errorMessage>'

    Examples:
    | Scenario     | userName     | password      |errorMessage             |
    | InvalidLogin | wrongUsername| wrongPassword |Invalid username/password|
