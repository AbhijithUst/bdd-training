Feature: AddTwoNumbers

Scenario Outline: Add two numbers
	Given the first number <num1>
	And the second nimber <num2>
	When the two numbers added
	Then the result should be <total>
	Example:
	| num1 | num2 | total |
	| 30   | 40   | 70    |
	| 20   | 20   | 40    |