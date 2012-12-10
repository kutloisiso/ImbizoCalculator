Feature: EnteringNumbers

Scenario Outline: Enter digits
	Given I have started the calculator
	When I press <digits>
	Then the result should be <result> on the screen
	Examples:
		| digits     | result     |
		| 1          | 1          |
		| 2          | 2          |
		| 12         | 12         |
		| 1234567890 | 1234567890 |