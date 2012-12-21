Feature: Division
	As a grocery shopper
	I want to know what a single item sold in a pack of items costs
	So that I can compare the unit price of different brands

Scenario: Divide one number by another
	Given I have started the calculator
	When I divide 29.94 by 6
	Then the result should be 4.99
