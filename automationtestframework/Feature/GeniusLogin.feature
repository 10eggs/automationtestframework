Feature: GeniusLogin
	Login Geature

@login
Scenario: Login
	Given I am on the genius homepage
	And I select the sign in button 
	And I input my genius login
	And I input my genius password
	When i select the login button
	Then I should be logged in