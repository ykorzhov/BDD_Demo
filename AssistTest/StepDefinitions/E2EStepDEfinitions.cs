using ActionsTest.POM;
using NUnit.Framework;
using SpecFlow.Actions.Selenium;




namespace AssistTest.StepDefinitions
{
    [Binding]
    public class E2EStepDEfinitions
    {
        private readonly PageModel pageModel;
        public E2EStepDEfinitions(PageModel pageModel)
        {
            this.pageModel = pageModel;
        }


        [Given("user enters username (.*)")]
        public void GivenUserEntersUsername(string username)
        {
            pageModel.EnterUsername(username);

        }

        [Given("user enters password (.*)")]
        public void GivenUserEntersPassword(string password)
        {
            pageModel.EnterPassword(password);

        }

        [When("user clicks login button")]
        public void WhenUserClicksLoginButton()
        {
            pageModel.ClickLoginButton();
        }

        [When("user adds product Jacket")]
        public void WhenUserAddsProductJacket()
        {
            pageModel.AddJacketToCart();
        }
        [When("user goes to cart")]
        public void WhenUserGoesToCart()
        {
            pageModel.GotoCart();
        }
        [When("user clicks Remove button")]
        public void WhenUserClickRemoveJacket()
        {
            pageModel.RemoveJacket();
        }
        [Then("cart icon should not show any number")]
        public void ThenCartShouldNotShowAnyNumber()
        {
            var cartBadge = pageModel.FindCartBadge();
            Assert.False(cartBadge, "Cart badge shows a number");
        }
    }
}