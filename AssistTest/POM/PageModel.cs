using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsTest.POM
{
    public class PageModel
    {
        private IBrowserInteractions _browserInteractions;

        public PageModel(IBrowserInteractions browserInteractions)
        {
            _browserInteractions = browserInteractions;
        }
        private IWebElement UserNameTextBox => _browserInteractions.WaitAndReturnElement(By.Id("user-name"));
        private IWebElement PasswordTextBox => _browserInteractions.WaitAndReturnElement(By.Id("password"));
        private IWebElement LoginButton => _browserInteractions.WaitAndReturnElement(By.Id("login-button"));
        public void GoTo(string url)
        {
            _browserInteractions.GoToUrl(url);
        }
        public void EnterUsername(string username)
        {
            UserNameTextBox.SendKeysWithClear(username);
        }

        public void EnterPassword(string password)
        {
            PasswordTextBox.SendKeysWithClear(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.ClickWithRetry();
        }
    }
}
