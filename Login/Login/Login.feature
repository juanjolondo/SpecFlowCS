Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Log in
	Given I have entered user into the username space
	And I have also entered pass into the password space
	When I press login
	Then It should change to form page
