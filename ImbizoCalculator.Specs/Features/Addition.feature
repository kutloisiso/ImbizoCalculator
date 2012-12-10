Feature: Addition

Scenario Outline: Add two numbers
	Given I have started the calculator
	When I add <first> and <second>
	Then the result should be <result> on the screen
	Examples: 
		| first | second | result |
		| 50    | 70     | 120    |
		| 10    | 10     | 20     |
