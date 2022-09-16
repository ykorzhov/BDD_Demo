using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlow.Actions.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace ActionsTest.POM
{
    public class PageModel
    {
        private IBrowserInteractions _browserInteractions;
        private readonly BrowserDriver browserDriver;

        public PageModel(IBrowserInteractions browserInteractions, BrowserDriver browserDriver)
        {
            _browserInteractions = browserInteractions;
            this.browserDriver = browserDriver;
        }
        private IWebElement UserNameTextBox => _browserInteractions.WaitAndReturnElement(By.Id("user-name"));
        private IWebElement PasswordTextBox => _browserInteractions.WaitAndReturnElement(By.Id("password"));
        private IWebElement LoginButton => _browserInteractions.WaitAndReturnElement(By.Id("login-button"));
        private IWebElement AddJacketToCartButton => _browserInteractions.WaitAndReturnElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        private IWebElement RemoveJacketButton => _browserInteractions.WaitAndReturnElement(By.Id("remove-sauce-labs-fleece-jacket"));
        private IWebElement GotoCartButton => _browserInteractions.WaitAndReturnElement(By.ClassName("shopping_cart_link"));
        private IWebElement CartBadge => _browserInteractions.WaitAndReturnElement(By.ClassName("shopping_cart_badge"));
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
        public void AddJacketToCart()
        {
            AddJacketToCartButton.Click();
        }

        public void GotoCart()
        {
            GotoCartButton.ClickWithRetry();
        }
        public void RemoveJacket()
        {
            RemoveJacketButton.ClickWithRetry();
        }
        //public bool FindCartBadge()
        //{
        //    _browserInteractions.WaitAndReturnElement(By.ClassName("shopping_cart_badge"));

        //    return true;
        //    //use fluent waiter, condition will return bool 
        //}

        public bool FindCartBadge()
        {
            //WebDriverWait wait = new WebDriverWait(browserDriver.Current, TimeSpan.FromSeconds(1));
            //try
            //{
            //    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("shopping_cart_badge")));
            //}
            try
            {
                _browserInteractions.WaitAndReturnElement(By.ClassName("shopping_cart_badge"));
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}

