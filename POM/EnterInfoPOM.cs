using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM
{
    public class EnterInfoPOM
    {
        private readonly IWebDriver driver;

        public EnterInfoPOM(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement FirstNameTextField => driver.FindElement(By.Id("first-name"));
        private IWebElement LastNameTextField => driver.FindElement(By.Id("last-name"));
        private IWebElement ZipCodeTextField => driver.FindElement(By.Id("postal-code"));
        private IWebElement ContinueButton => driver.FindElement(By.Id("continue"));


        public void EnterFirstName(string firstName)
        {
            FirstNameTextField.SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            LastNameTextField.SendKeys(lastName);
        }
        public void EnterZipCode(string zip)
        {
            ZipCodeTextField.SendKeys(zip);
        }
        public OverviewPOM ClickContinueButton()
        {
            ContinueButton.Click();
            return new OverviewPOM(driver);
        }

    }
}
