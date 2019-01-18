Feature: Userform


@smoke @testtag
Scenario: User Details form entry verification
	Given I navigate to application
	Given I enter username and password
	| UserName | Password |
	| admin    | admin    |
	Given I click login
	Given I start entering user form details like
	| Initial | FirstName | MiddleName |
	| k       | Karthik   | k          |
	Given I click submit button

