using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class CartPOM
    {
        private readonly IWebDriver driver;

        public CartPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement CheckoutButton => driver.FindElement(By.Id("checkout"));


        public EnterInfoPOM ClickCheckout()
        {
            CheckoutButton.Click();
            return new EnterInfoPOM(driver);
        }
    }
}
