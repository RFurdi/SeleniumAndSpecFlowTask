Feature: SaucedemoLogInFeature

I am testing Login page of Saucedemo page ot test that everything works as expected

@LogIn
Scenario: Login failed
	Given I have navigated to Saucedemo web site
	And I entered '<Username>' as Username
	And I entered '<Password>' as Password
	When I submit LOGIN button
	Then Login should fail with '<Message>'
Examples:
	| Username      | Password     | Message                                                                   |
	|               |              | Epic sadface: Username is required                                        |
	| Robert        |              | Epic sadface: Password is required                                        |
	|               | Furdi        | Epic sadface: Username is required                                        |
	| Robert        | Furdi        | Epic sadface: Username and password do not match any user in this service |
	| Robert        | secret_sauce | Epic sadface: Username and password do not match any user in this service |
	| standard_user | Furdi        | Epic sadface: Username and password do not match any user in this service |
Scenario: Login successfully
	Given I have navigated to Saucedemo web site
	And I entered correct Username '<CorrectUsername>'
	And I entered correct Password '<CorrectPassword>'
	When I submit LOGIN button
	Then I should be navigated to Inventory page
Examples:
	| CorrectUsername | CorrectPassword |
	| standard_user   | secret_sauce    |
