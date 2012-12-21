Feature: Addition
	As a grocery shopper
	I want to know the sum of my purchases
	So that I don't blow my budget
	
Scenario: Add decimal numbers
	Given I have started the calculator
	When I add the following amounts
		| amount |
		| 49.99  |
		| 69.95  |
		| 14.5   |
	Then the result should be 134.44

Scenario: Perform another calculation
	Given I have already performed a calculation
	When I add the following amounts
		| amount |
		| 49.99  |
		| 69.95  |
		| 14.5   |
	Then the result should be 134.44

Scenario: Continue a calculation
	Given I have started the calculator
	When I add the following amounts
		| amount |
		| 10     |
		| 20     |
	And I continue to add the following amounts
		| amount |
		| 30     |
		| 40     |
	Then the result should be 100