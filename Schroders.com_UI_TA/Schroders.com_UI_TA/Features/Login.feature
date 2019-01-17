Feature: Login
	Check if Login functionality works



@Feature_Scenarios
Scenario: Login user as Administrator
	Given I navigate to application
	When I enter username and password
		| UserName | Password |
		| admin    | admin    | 
	And I click login
	Then I should see user logged in the application


