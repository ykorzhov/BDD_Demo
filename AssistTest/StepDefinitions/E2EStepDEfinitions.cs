using ActionsTest.POM;
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


    }
}