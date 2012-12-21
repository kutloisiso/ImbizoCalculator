Feature: Subtraction
	As a grocery shopper
	I want to subtract an amount from the total
	So that I can correct a mistakenly added amount

Scenario: Subtract an amount
	Given I have started the calculator
	When I add the following amounts
		| amount |
		| 10     |
		| 20     |
	And I subtract 20
	Then the result should be 10
