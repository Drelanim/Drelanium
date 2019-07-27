Feature: TestCallToPlayPalStepLibrary

# this shows that we can execute steps defined in other projects
# calling a RestApi test step from a GUI test scenario

Scenario: get token happy path
	When get PayPal client credential token with following credentials and OAuth2 results saved as oauth2result
	| clientId | secret  |
	| default  | default |
	Then the token returned in OAuth2 results oauth2result is valid

Scenario Outline: get token - invalid secret or client id
	When get PayPal client credential token with following credentials and OAuth2 results saved as oauth2result
	| clientId   | secret   |
	| <clientId> | <secret> |
	Then the OAuth2 results oauth2result contains HttpErrorReason <errorReason>

	Examples: 
	| description   | errorReason | clientId                                                                          | secret                                                                           |
	| bad client id | Unauthorized | bad-client-id                                                                    | EPfyBKxpYf3j4HSQuWGFPInbw_t7_a-zPcTwRSOpbu-uuXZhPRQPEG0NPyFUR-BuGDZFdnzmEtKT1zkO |
	| bad secret    | Unauthorized | AU-YNW4xk0SxEwR63_roCXnlJ-7ViTkx2PkGHvXC2x9d1LVVIibxGL-hcQRl830zz35AlG6XYr7CG5YM | bad-secret                                                                       |    
	




