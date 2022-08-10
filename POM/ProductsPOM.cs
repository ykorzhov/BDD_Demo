using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class ProductsPOM
    {
        private readonly IWebDriver driver;

        public ProductsPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement AddBackpackToCartButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement AddOnesieToCartButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        private IWebElement AddLightToCartButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        private IWebElement AddJacketToCartButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        private IWebElement GoToCartButton => driver.FindElement(By.ClassName("shopping_cart_link"));


        public void AddBackpackToCart()
        {
            AddBackpackToCartButton.Click();
        }
        public void AddOnesieToCart()
        {
            AddOnesieToCartButton.Click();
        }
        public void AddLightToCart()
        {
            AddLightToCartButton.Click();
        }
        public void AddJacketToCart()
        {
            AddJacketToCartButton.Click();
        }
        public CartPOM GoToCart()
        {
            GoToCartButton.Click();
            return new CartPOM(driver);
        }
    }
}
