using OpenQA.Selenium.Chrome;
using POM;

namespace Test
{
    public class SauseDemoTests
    {
        private ChromeDriver driver;
        private LoginPOM loginPage;
        private ProductsPOM productsPage;
        private CartPOM cartPage;
        private EnterInfoPOM infoPage;
        private OverviewPOM overviewPage;
        private CheckoutCompletePOM checkoutPage;

        private const string standardUser = "standard_user";
        private const string password = "secret_sauce";
        private const string userName = "Yana";
        private const string userLastName = "K";
        private const string zipCode = "666";


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPOM(driver);
            loginPage.WithDelay(500); // adding a delay 
            productsPage = new ProductsPOM(driver);
            cartPage = new CartPOM(driver);
            infoPage = new EnterInfoPOM(driver);
            overviewPage = new OverviewPOM(driver);
            checkoutPage = new CheckoutCompletePOM(driver);

            driver.Url = "https://www.saucedemo.com/";
        }

        [Test]
        public void Test1()
        {

            loginPage.EnterUsername(standardUser);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginButton();

            //loginPage.EnterUsername(standardUser)
            //         .EnterPassword(password)
            //         .ClickLoginButton()
            //         .AddLightToCart();

            // chaining -- possible if you return POM object in methods (instead of using void).
            // Improves readability, but debugging is a bit more difficult with it, cause it chooses all code between ; and ; which could be many methods.
            // so you'd need to put breakpoints in methods, not in test 


            productsPage.AddLightToCart();
            productsPage.AddJacketToCart();
            productsPage.GoToCart();

            cartPage.ClickCheckout();

            infoPage.EnterFirstName(userName);
            infoPage.EnterLastName(userLastName);
            infoPage.EnterZipCode(zipCode);
            infoPage.ClickContinueButton();

            overviewPage.ClickFinishButton();
            

            var thankyouHeader = checkoutPage.FindThankYouHeader();

            Assert.True(thankyouHeader, "Thank you header is not found.");

            //Assert.AreEqual(expectedValueInFirstNumberField, actualValueInFirstNumberField, "dfdfd");

            //Assert.That(thankyouHeader, Is.True);

            //Assert.That(thankyouHeader, new NUnit.Framework.Constraints.AndOperator().ApplyOperator(Is.True, Is.True));
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        //without teardown driver should be closed in task manager !!!
    }
}