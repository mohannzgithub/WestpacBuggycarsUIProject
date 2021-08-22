Feature: 1Login
  As a User
  I want to Login
  So that I can rank my cars in Buggy car Website

@prod
Scenario Outline: User login to buggy cars website
   Given User navigates to Buggy cars website
    When User Enter the '<Username>' And '<Password>'
    And User Clicks on Login button
    Then User should able to see Home Page

 Examples:
    | Scenario   | Username | Password |
    | ValidLogin |  bugcrgub|Buggub@123|

 @prod
 Scenario Outline: User can not login to buggy cars website with invalid credentials
    Given User navigates to Buggy cars website
     When User Enter the '<Username>' And '<Password>'
    And User Clicks on Login button
    Then User should able to see error message '<ErrorMessage>'

    Examples:
    | Scenario     | Username     | Password      |ErrorMessage             |
    | InvalidLogin | wrongUsername| wrongPassword |Invalid username/password|
