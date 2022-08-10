using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class CheckoutCompletePOM
    {
        private readonly IWebDriver driver;

        public CheckoutCompletePOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement ThankYouHeader => driver.FindElement(By.ClassName("complete-header"));

        public bool FindThankYouHeader()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("complete-header")));
            }
            catch
            {
                return false;
            }

            return true;

        }
    }
}
