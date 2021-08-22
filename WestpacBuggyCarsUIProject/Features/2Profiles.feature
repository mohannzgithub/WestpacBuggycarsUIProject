Feature: 2Profiles


@prod
Scenario Outline: User login to buggy cars website
    Given User navigates to Buggy car with '<userName>' And '<password>'
    When User Clicks on Login button
   When User Navigates to profile Page
   And User updates '<firstName>' And '<lastName>'
   Then User can see '<profileSuccessMessage>' message

 Examples:
  	| Scenario      | userName | password  | firstName | lastName | profileSuccessMessage                 |
	| UpdateProfile | bugcrgub | Buggub@123 | bugcrb    | brcgub  | The profile has been saved successful |

@prod
Scenario Outline: Validate Save button disable when Empty FirstName and LastName in profile 
   Given User navigates to Buggy car with '<userName>' And '<password>'
   When User Clicks on Login button
   And User Navigates to profile Page
   And User clears the FirstName And LastName
   Then User should not be able to Update Profile

 Examples:
  	| Scenario      | userName | password  |
	| UpdateProfile | bugcrgub | Buggub@123 |