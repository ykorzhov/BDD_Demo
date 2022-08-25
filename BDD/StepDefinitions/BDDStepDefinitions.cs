using BDD.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM;

namespace BDD.StepDefinitions
{
    [Binding]
    public sealed class BDDStepDefinitions
    {

        static WebDriver driver = WebdriverUtils.getInstance();
        //LoginPOM loginPage = new LoginPOM(driver);
        ProductsPOM productsPage = new ProductsPOM(driver);
        CartPOM cartPage = new CartPOM(driver);
        EnterInfoPOM infoPage = new EnterInfoPOM(driver);
        OverviewPOM overviewPage = new OverviewPOM(driver);
        CheckoutCompletePOM checkoutPage = new CheckoutCompletePOM(driver);

        private readonly TestData testData;
        public BDDStepDefinitions(TestData testData)
        {
            this.testData = testData;
        }

        [When("user adds product (.*)")]
        public void WhenUserAddsProduct(string productTitle)
        {
            testData.ProductTitle = productTitle;
            switch (productTitle)
                {
                case "Backpack":
                    productsPage.AddBackpackToCart();
                    break;

                case "Light":
                    productsPage.AddLightToCart();
                    break;

                case "Jacket":
                    productsPage.AddJacketToCart();
                    break;

                case "Onesie":
                    productsPage.AddOnesieToCart();
                    break;
            }
        }

        //[When("user adds light to cart")]
        //public void WhenUserAddsLightToCart()
        //{
        //    productsPage.AddLightToCart();
        //}
        //[When("user adds jacket to cart")]
        //public void WhenUserAddsJacketToCart()
        //{
        //    productsPage.AddJacketToCart();
        //}
        [When("user goes to cart")]
        public void WhenUserGoesToCart()
        {
            productsPage.GoToCart();
        }

        [When("user clicks Checkout button")]
        public void WhenUserClicksCheckoutButton()
        {
            cartPage.ClickCheckout();
        }
        [When("user enters first name (.*)")]
        public void WhenUserEntersFirstName(string firstName)
        {
            infoPage.EnterFirstName(firstName);
        }
        [When("user enters last name (.*)")]
        public void WhenUserEntersLastName(string lastName)
        {
            infoPage.EnterLastName(lastName);
        }
        [When("user enters zip code (.*)")]
        public void WhenUserEntersZip(string zip)
        {
            infoPage.EnterZipCode(zip);
        }

        [Then("selected items are present in Overview page")]
        public void CheckSelectedItemsOnOverviewPage()
        {
            var itemsOnOverviewPage = overviewPage.GetText();
            var titleContains = itemsOnOverviewPage.Contains(testData.ProductTitle);
            Assert.IsTrue(titleContains, "Item not found");
        }

        [When("user clicks Continue button")]
        public void WhenUserClicksContinueButton()
        {
            infoPage.ClickContinueButton();
        }

        [When("user clicks Finish button")]
        public void WhenUserClicksFinishButton()
        {
            overviewPage.ClickFinishButton();
        }
        [Then("Thank You header is shown")]
        public void ThenHeaderIsShown()
        {
            var thankyouHeader = checkoutPage.FindThankYouHeader();

            Assert.True(thankyouHeader, "Thank you header is not found.");
        }

        [When("user clicks Cancel button")]
        public void WhenUserClicksCancelButton()
        {
            overviewPage.ClickCancelButton();
            Thread.Sleep(2000);
        }
        [Then("Products page is shown")]
        public void ThenProductsPageIsShown()
        {
            var productsPageTitle = productsPage.FindProductsPageTitle();

            Assert.True(productsPageTitle, "Products title is not found.");
        }

    }
}