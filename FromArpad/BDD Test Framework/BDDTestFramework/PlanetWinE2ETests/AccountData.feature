Feature: AccountData


Scenario Outline: access the acount data page on specified browser in italian
	Given Browser type is <Browser>
	Given login to PlanetWin with default user credentials
	When logged in and selecting the account data tab
	Then verify username on account data tab

	Examples: 
	| Browser |
	| CHROME  |
	| FIREFOX |
	| EDGE    |

Scenario Outline: access the acount data page on specified browser and language
	Given Browser type is <Browser>
	Given login to PlanetWin with following data
	| username       | password | language   |
	| EPAM_QA_BUD_24 | Arpito   | <Language> |
	When logged in and selecting the account data tab
	Then verify username on account data tab against username EPAM_QA_BUD_24

	Examples: 
	| Browser | Language   |
	| CHROME  | Italiano   |
	| FIREFOX | English    |
	| EDGE    | Deutsch    |
	| CHROME  | Français   |
	| FIREFOX | Argentina  |
	| EDGE    | Balkans    |
	| CHROME  | Български  |
	| FIREFOX | Polski     |
	| EDGE    | Română     |
	| CHROME  | Shqip      |
	| FIREFOX | Österreich |
	| EDGE    | Chinese    |
	| CHROME  | Turkish    |