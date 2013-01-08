Feature: Clear
	As a grocery shopper
	I want to clear the number or calculation I have entered
	So that I can correct a mistake

Scenario: Clear number
	Given I have entered 10
	When I add 5 and clear it
	And I add 6
	Then the result should be 16

Scenario: Clear calculation
	Given I have already performed a calculation
	When I clear the calculation
	Then the result should be 0
