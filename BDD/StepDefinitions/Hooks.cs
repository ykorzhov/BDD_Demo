using BDD.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDD.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        WebDriver driver = WebdriverUtils.getInstance();

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver.Url = "https://www.saucedemo.com/";
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
        }
    }
}