Feature: Login

Scenario Outline: login to PlanetWin365
	Given Browser type is <Browser>
	When login to PlanetWin with following data
	| username       | password | language   |
	| EPAM_QA_BUD_22 | Arpito   | <Language> |
	Then verify logged in condition

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

Scenario Outline: login to PlanetWin365 with bad credentials
	Given Browser type is <Browser>
	When login to PlanetWin with following data
	| username     | password    | language   |
	| EPAMtestuser | badpassword | <Language> |
	Then verify access denied popup presented within 15 seconds with alert text <ErrorMsg>

	Examples: 
	| Browser | Language   | ErrorMsg                                   |
	| CHROME  | Italiano   | Username o Password errati                 |
	| FIREFOX | English    | Incorrect Username and Password            |
	| EDGE    | Deutsch    | Benutzername oder Passwort falsch          |
	| CHROME  | Français   | Nom usager ou Mot de passe erronés         |
	| FIREFOX | Argentina  | Nombre de usuario y/o contraseña inválidos |
	| EDGE    | Balkans    | Korisničko ime i lozinka nisu tačni        |
	| CHROME  | Български  | Грешно потребителско име и пар             |
	| FIREFOX | Polski     | Bledna nazwa uzytkownika lub haslo         |
	| EDGE    | Română     | Username sau Password greşite              |
	| CHROME  | Shqip      | username ose password jane gabim           |
	| FIREFOX | Österreich | no error text available yet                |
	| EDGE    | Chinese    | 用户名和密码错误                            |
	| CHROME  | Turkish    | no error text availabl                     |
