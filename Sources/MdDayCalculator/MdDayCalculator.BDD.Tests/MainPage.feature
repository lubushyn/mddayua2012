Feature: MainPage
	In order to use MdDayCalculator
	As a WP7 user
	I want to be read the main page

Scenario: Main Page loads after a few seconds
	Given my app is clean installed and running
    Then I enter "2" into the control "tbFirstNumber"
    Then I enter "3" into the control "tbSecondNumber"
    Then I press the control "btnCalculate"
    Then I see the control "tbResult" contains "6"