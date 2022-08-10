using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using POM;

namespace BDD.StepDefinitions
{
    [Binding]
    public sealed class BDDStepDefinitions
    {

        static ChromeDriver driver = new ChromeDriver();
        LoginPOM loginPage = new LoginPOM(driver);
        ProductsPOM productsPage = new ProductsPOM(driver);
        CartPOM cartPage = new CartPOM(driver);
        EnterInfoPOM infoPage = new EnterInfoPOM(driver);
        OverviewPOM overviewPage = new OverviewPOM(driver);
        CheckoutCompletePOM checkoutPage = new CheckoutCompletePOM(driver);

        [Given("user navigates to home page")]
        public void GivenUserOpensHomePage()
        {
            driver.Url = "https://www.saucedemo.com/";

            //throw new PendingStepException();
        }

        [Given("user enters username (.*)")]
        public void GivenUserEntersUsername (string username)
        {
            loginPage.EnterUsername(username);

            //throw new PendingStepException();
        }

        [Given("user enters password (.*)")]
        public void GivenUserEntersPassword(string password)
        {
            loginPage.EnterPassword(password);

        }

        [When("user clicks login button")]
        public void WhenUserClicksLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [When("user adds light to cart")]
        public void WhenUserAddsLightToCart()
        {
            productsPage.AddLightToCart();
        }
        [When("user adds jacket to cart")]
        public void WhenUserAddsJacketToCart()
        {
            productsPage.AddJacketToCart();
        }
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
    }
}