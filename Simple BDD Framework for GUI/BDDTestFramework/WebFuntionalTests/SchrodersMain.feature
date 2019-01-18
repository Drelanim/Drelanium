Feature: SchrodersMain
Background: 
	Given Headless Mode is ON

Scenario Outline: SHOW ME function
	Given Browser type is <Browser>
	Given bring up main page
	When bring up the Show Me page via button
	Then all of the Show Me page link containers are present
	Examples: 
	| Browser |
	| CHROME  |
	| FIREFOX |

Scenario Outline: Search function - not found
	Given Browser type is <Browser>
	Given bring up main page
	Given press the search button and let the search page come up
	When submitting a search for text ---thisIsAnUnknownSearchTerm---
	Then the search fails with Sorry, there are no matching results
	Examples: 
	| Browser |
	| CHROME  |
	| FIREFOX |


