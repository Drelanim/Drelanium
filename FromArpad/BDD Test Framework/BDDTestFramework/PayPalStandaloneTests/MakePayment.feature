Feature: MakePayment

Background: 
	Given get PayPal client credential token with following credentials and OAuth2 results saved as oauth2result
	| clientId | secret  |
	| default  | default |

Scenario Outline: Make PayPal Payment - happy path

	When PayPal payment endpoint is called with token from oauth2result with following content and the response payload is saved as results
	| intent   | return_url                            | cancel_url                               | payment_method   | total   | currency   |
	| <intent> | https://example.com/redirect_url.html | https://example.com/your_cancel_url.html | <payment_method> | <total> | <currency> |
	Then http status code in response results equals 201

	Examples:
	| intent    | payment_method | total  | currency |
	| sale      | paypal         | 100.00 | HUF      |
	

Scenario Outline: Make PayPal Payment - validation error
	When PayPal payment endpoint is called with token from oauth2result with following content and the response payload is saved as results
	| intent   | return_url                            | cancel_url                               | payment_method   | total   | currency   |
	| <intent> | https://example.com/redirect_url.html | https://example.com/your_cancel_url.html | <payment_method> | <total> | <currency> |
	Then http status code in response results equals 400
	And the error message in the results payload results equals <errorMessage>

	Examples:
	| description        | intent | payment_method | total  | currency | errorMessage                                       |
	| bad intent         | sales  | paypal         | 100.00 | HUF      | Payment intent must be sale or authorize or order. |
	#| bad payment method | sale   | cash           | 100.00 | HUF      | Payment method must be credit_card or paypal.      |
	| bad total          | sale   | paypal         | 0      | HUF      | Amount cannot be zero                              |
	| bad currency       | sale   | paypal         | 100.00 | DOLLAR   | Currency should be a valid ISO currency code       |




