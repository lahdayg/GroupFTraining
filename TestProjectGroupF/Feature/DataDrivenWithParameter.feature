Feature: DataDrivenWithParameter
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up button 
	And I enter Username "Lucas"
	And I enter Email Address "ahmed002"
	#And I enter something that doesn`t make sense
	#And I click on Sign in button
	And I enter Password "PasswordSecure"
	When I click on Sign Up button
	#Then I should be able to sign up successfully on the website