Feature: Profile
  As a User
  I want a profile form
  So that I can update my profile details

  Background: User Register
  Given User navigates to Buggy cars website
    When User Enter the '<Username>' And '<Password>'
    | Username | Password  |
    | bugcrgub | Buggub@123|
    And User Clicks on Login button
    Then User should able to see Home Page

  @prod
  Scenario Outline: User updates profile name
    Given User Navigates to profile Page
    When User updates '<firstName>' And '<lastName>'
    Then User can see '<profile Success>' message

  Examples:
     | Scenario      | firstName | lastName | profile Success |
     | UpdateProfile | bugcrb    | brcgub   | The profile has been saved successful                |