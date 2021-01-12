Feature: FillOutForm
Fill out the form

@mytag
Scenario: Fill out the form
	Given I navigate to the website
	And i enter my first name in the first name field
	And I input my name in the last name field
	And I select the gender option of male
	And I select 2 years of experience
	And I input a relevant date
	And I select the Manual tester checkbox under the profession option
	And I select the selenium webdriver option under the automation tools 
	And I select the continents dropdown to select the option of Europe
	And I select the option of browser commands under the selenium commands heading
	And I select the submit button