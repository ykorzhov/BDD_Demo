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
        private IWebElement FinishButton => driver.FindElement(By.Id("finish"));

        public CheckoutCompletePOM ClickFinishButton()
        {
            FinishButton.Click();
            return new CheckoutCompletePOM(driver);
        }
    }
}
