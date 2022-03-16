Feature: SaucedemoHomePageFeature

A short summary of the feature

@HomePage
Scenario: Saucedemo Home page
	Given I Logged in page
	When I click Menu button
	Then Menu has been displayed

Scenario: Cart
	Given I Logged in page 
	And I add Sauce Labs Bike Light to Cart
	Then I navigated to Cart page

