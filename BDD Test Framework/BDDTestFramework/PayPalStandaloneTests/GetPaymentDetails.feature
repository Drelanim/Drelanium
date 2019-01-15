
Feature: GetPaymentDetails

Background:
	Given get PayPal client credential token with following credentials and OAuth2 results saved as oauth2result
	| clientId | secret  |
	| default  | default |


Scenario Outline: Get Payment Details - happy path
	When PayPal payment endpoint is called with token from oauth2result with following content and the response payload is saved as paymentResults
	| intent   | return_url                            | cancel_url                               | payment_method   | total   | currency   |
	| <intent> | https://example.com/redirect_url.html | https://example.com/your_cancel_url.html | <payment_method> | <total> | <currency> |
	Then http status code in response paymentResults equals 201

	When PayPal GEt Payment Details endpoint is called with token from oauth2result with payment ID from payment response paymentResults and response saved as paymentDetailsResponse
	Then http status code in response paymentDetailsResponse equals 200
	And the contents of PayPal Get Payment Details response paymentDetailsResponse matches the payment details returned from the previous payment call in paymentResults


	Examples:
	| intent    | payment_method | total  | currency |
	| sale      | paypal         | 100.00 | HUF      |
