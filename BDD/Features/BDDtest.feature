Feature: SauceDemo

@mytag
Scenario: E2E
	Given user navigates to home page
	And user enters username standard_user
	And user enters password secret_sauce
	When user clicks login button
	And user adds light to cart
	And user adds jacket to cart
	And user goes to cart
	And user clicks Checkout button
	And user enters first name Yana
	And user enters last name Korzhova
	And user enters zip code 777
	And user clicks Continue button
	And user clicks Finish button
	Then Thank You header is shown

	

