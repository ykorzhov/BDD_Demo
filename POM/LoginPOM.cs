using OpenQA.Selenium;

namespace POM
{
    public class LoginPOM : PageObjectBase
    {
        private readonly IWebDriver driver; //інкапсуляція, тому driver private

        public LoginPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement UserNameTextBox => driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordTextBox => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        //локатори можуть бути публічні, якщо архітектура 3 або більше рівнів і методи будуть винесені до рівня драйвера

        public LoginPOM EnterUsername(string username)
        {
            //UserNameTextBox.SendKeys(username);

            DoAction(() => UserNameTextBox.SendKeys(username));

            return this;
        }

        public LoginPOM EnterPassword(string password)
        {
            //PasswordTextBox.SendKeys(password);

            DoAction(() => PasswordTextBox.SendKeys(password));

            return this;
        }

        public ProductsPOM ClickLoginButton()
        {
            /*LoginButton.Click()*/;

            DoAction(() => LoginButton.Click());

            return new ProductsPOM(driver);
        }
    }


}