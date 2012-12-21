Feature: Multiplication
	As a grocery shopper
	I want to know what a certain quantity of an item will cost
	So that I don't have to repeatedly add the same amount

Scenario: Multiply two numbers
	Given I have started the calculator
	When I multiply 4.99 by 6
	Then the result should be 29.94
