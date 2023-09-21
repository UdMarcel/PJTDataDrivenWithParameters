Feature: DataDriven1

A short summary of the feature

@tag1
Scenario: [data Driven with Parameters]
	Given I navigate to the wesbite "http://angularjs.realworld.io/#/register"
	And I Click on SignUp
	And I Enter my Username "Manny3" 
	And I Enter my email "manny3@yahoo.com"
	And I Enter passowrd "manny543213"
	When I Click on the Sign up button 
	Then I Should be able to register succesfully 
