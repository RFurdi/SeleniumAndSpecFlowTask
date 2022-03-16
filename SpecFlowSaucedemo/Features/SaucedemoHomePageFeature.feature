Feature: SaucedemoHomePageFeature

I am testing Home page of Saucedemo page ot test that everything works as expected

@HomePage
Scenario: Saucedemo Home page
	Given I Logged in page
	When I click Menu button
	Then Menu has been displayed

Scenario: Cart
	Given I Logged in page 
	And I add Sauce Labs Bike Light to Cart
	Then I navigated to Cart page

