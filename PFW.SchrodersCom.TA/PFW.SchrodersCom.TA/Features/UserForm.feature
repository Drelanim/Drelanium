﻿Feature: Userform specific feature

Scenario: I fill out the userform on the page
	Given I am on the EA Login Page
	When I type my username and password
	And I click the Login button
	And I fill out the userform on the page
	Then The userform is filled out