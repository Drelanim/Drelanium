Feature: SchrodersMainTabs
Background: 
	Given Headless Mode is OFF


Scenario Outline: Presence of main tabs
	Given Browser type is <Browser>
	When bring up main page
	Then the About Us, Insights and People tabs are present
	Examples: 
	| Browser |
	| CHROME  |
	| FIREFOX |

Scenario Outline: Insights Tab - menu items
	Given Browser type is <Browser>
	Given bring up main page
	When select Insights tab
	Then the Alternatives item is present on the Most Recent menu
	Examples: 
	| Browser |
	| CHROME  |
	| FIREFOX |




