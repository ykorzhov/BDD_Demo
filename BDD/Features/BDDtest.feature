@MyFeatureTag
Feature: SauceDemo

@tag1 @E2E
Scenario: E2E_CompleteOrder
	Given user enters username standard_user
	And user enters password secret_sauce
	When user clicks login button
	When user adds product Light
	And user goes to cart
	And user clicks Checkout button
	And user enters first name Yana
	And user enters last name Korzhova
	And user enters zip code 777
	And user clicks Continue button
	Then selected items are present in Overview page
	When user clicks Finish button
	Then Thank You header is shown

@tag2 @E2E
Scenario: E2E_CancelOrder
	Given user enters username standard_user
	And user enters password secret_sauce
	When user clicks login button
	And user adds product Backpack
	And user goes to cart
	And user clicks Checkout button
	And user enters first name Name
	And user enters last name Surname
	And user enters zip code 666
	And user clicks Continue button
	And user clicks Cancel button
	Then Products page is shown

#dotnet test C:\Users\ykorzh\source\repos\SaucedemoTA\BDD\BDD.csproj --filter:"TestCategory=E2E"
#dotnet test C:\Users\ykorzh\source\repos\SaucedemoTA\BDD\BDD.csproj --filter Category=tag1
	

