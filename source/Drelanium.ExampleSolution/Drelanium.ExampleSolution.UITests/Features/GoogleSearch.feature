Feature: Google Search
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@GoogleSearch
Scenario: Search for SpecFlow
	Given I am visiting Google
	When I search for "SpecFlow"
	Then the word "SpecFlow" can be found in every search result