Feature: Form
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Fill form
	Given I have entered Juanito into the name space
	And I have entered Alimaña into the last name space
	And I have also entered 20 into the age space
	When I press send
	Then It should show correct on the screen
