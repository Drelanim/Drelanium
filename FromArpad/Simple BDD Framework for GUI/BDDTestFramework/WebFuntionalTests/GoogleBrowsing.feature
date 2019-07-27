Feature: GoogleBrowsing
Background: 
	Given Headless Mode is ON

Scenario Outline: launch google
	Given Browser type is <Browser>
	Given Google is launched on url http://google.com


	Examples: 
	| Browser | 
	| CHROME  |
	| FIREFOX | 




