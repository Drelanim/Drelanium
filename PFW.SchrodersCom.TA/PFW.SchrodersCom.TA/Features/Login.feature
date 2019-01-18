Feature: Login


@mytag
Scenario: Login user as Administrator
	Given I navigate to application
	Given I enter username and password
	| UserName | Password |
	| admin    | admin    |
	Given I click login
	Then I should see user logged in to the application

