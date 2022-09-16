//using BDD.Utils;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDD.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer container;

        public Hooks(IObjectContainer container)
        {
            this.container = container;
        }
        IWebDriver driver;

        [BeforeScenario]
        public void CreateWebDriver()
        {
            ChromeDriver driver = new ChromeDriver();
            container.RegisterInstanceAs<IWebDriver>(driver, "webdriver");

            //container.RegisterTypeAs<ChromeDriver, IWebDriver>("webdriver");

            driver.Url = "https://www.saucedemo.com/";
        }
        //// For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        ////WebDriver driver = WebdriverUtils.getInstance();
        //private readonly WebDriverSupport webDriver;
        //public Hooks(WebDriverSupport webDriver)
        //{
        //    this.webDriver = webDriver;
        //}

        //[BeforeScenario]
        //public void InitializeWebDriver()
        //{
        //    var driver = new ChromeDriver();
        //    webDriver.objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        //    driver.Url = "https://www.saucedemo.com/";
        //}

        [AfterScenario]
        public void DestroyWebDriver()
        {
            driver = container.Resolve<IWebDriver>("webdriver");

            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
        //public void AfterScenario()
        //{
        //    driver.Close();
        //}

        //HW: implement Context Injection for wevdriver 
        // + read about plugins https://docs.specflow.org/projects/specflow/en/latest/Extend/Plugins.html
    }
}