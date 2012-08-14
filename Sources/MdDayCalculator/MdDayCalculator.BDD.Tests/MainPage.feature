Feature: Addition Tests
    In order to test the calculator
    As a WP7 User
    I want to perform some additions

Scenario: Correctly add some numbers
    Given my app is clean installed and running
    When I enter "2" into the control "tbFirstNumber"
    And I enter "3" into the control "tbSecondNumber"
    And I press the control "btnCalculate"
    Then I see the control "tbResult" contains "6"