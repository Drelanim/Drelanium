Feature: Login specific feature


Scenario: Login to the EA Login page
	Given I am on the EA Login Page
	When I type my username and password
	And I click the Login button
	Then I am logged in