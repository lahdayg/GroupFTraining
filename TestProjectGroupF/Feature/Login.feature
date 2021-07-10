Feature: Login
	In order to use the website
	And all the features on it
	I will need to first Register then Login

@mytag
Scenario: Valid Login
	Given I navigate to the website
	And I click on Sign up button 
	And I enter Username
	And I enter Email Address
	#And I enter something that doesn`t make sense
	#And I click on Sign in button
	And I enter Password
	When I click on Sign Up button
	Then I should be able to sign up successfully on the website