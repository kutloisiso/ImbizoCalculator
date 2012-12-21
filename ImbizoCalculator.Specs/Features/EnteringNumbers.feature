Feature: EnteringNumbers

Scenario: Calculator just started
	Given I have started the calculator
	Then the result should be 0

Scenario Outline: Enter digits
	Given I have started the calculator
	When I press <digits>
	Then the result should be <result>
	Examples:
		| digits     | result     |
		| 1          | 1          |
		| 12         | 12         |
		| 1234567890 | 1234567890 |
		| 123.456    | 123.456    |