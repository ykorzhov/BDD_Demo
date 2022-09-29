@MyFeatureTag
Feature: SauceDemo

@tag3 @E2E
Scenario: E2E_CompleteOrder_Actions
	Given user enters username standard_user
	And user enters password secret_sauce
	When user clicks login button
	When user adds product Jacket
	And user goes to cart
	And user clicks Remove button
	Then cart icon should not show any number