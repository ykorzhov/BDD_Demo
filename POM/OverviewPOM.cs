using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class OverviewPOM
    {
        private readonly IWebDriver driver;

        public OverviewPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement ProductTitle => driver.FindElement(By.ClassName("inventory_item_name"));
        private IWebElement FinishButton => driver.FindElement(By.Id("finish"));
        private IWebElement CancelButton => driver.FindElement(By.Id("cancel"));
        public string GetText()
        {
            return ProductTitle.Text;
        }

        public void ClickCancelButton()
        {
            CancelButton.Click();
        }

        public CheckoutCompletePOM ClickFinishButton()
        {
            FinishButton.Click();
            return new CheckoutCompletePOM(driver);
        }
    }
}
