Feature: TestCallToPlanetWinGuiStep

Scenario: login to PlanetWin365
	Given Browser type is FIREFOX
	When login to PlanetWin with following data
	| username       | password | language |
	| EPAM_QA_BUD_24 | Arpito   | Italiano |
	Then verify logged in condition

Scenario: login to PlanetWin365 with bad credentials
	Given Browser type is FIREFOX
	When login to PlanetWin with following data
	| username     | password    |language |
	| EPAMtestuser | badpassword |Italiano |
	Then verify access denied popup presented within 15 seconds with alert text Username o Password errati