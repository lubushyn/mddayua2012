Feature: MainPage
	In order to use MdDayCalculator
	As a WP7 user
	I want to multiple two values

Scenario: Multiplication result is correct
	Given my app is clean installed and running
    Then I enter "2" into the control "tbFirstNumber"
    Then I enter "3" into the control "tbSecondNumber"
    Then I press the control "btnCalculate"
    Then I see the control "tbResult" contains "6"

Scenario: Both controls are empty
	Given my app is clean installed and running
	Then I press the control "btnCalculate"
	Then I see the control "tbValidationMessage" contains "Please enter two numbers."
 
Scenario: First control value is string
	Given my app is clean installed and running
	Then I enter "invalid value" into the control "tbFirstNumber"
	Then I enter "3" into the control "tbSecondNumber"
	Then I press the control "btnCalculate"
	Then I see the control "tbValidationMessage" contains "Please enter a valid first number."

Scenario: Second control is string
	Given my app is clean installed and running
	Then I enter "invalid value" into the control "tbSecondNumber"
	Then I enter "2" into the control "tbFirstNumber"
	Then I press the control "btnCalculate"
	Then I see the control "tbValidationMessage" contains "Please enter a valid second number."