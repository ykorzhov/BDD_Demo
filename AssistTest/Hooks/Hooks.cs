using TechTalk.SpecFlow;
using ActionsTest.POM;
using SpecFlow.Actions.Selenium;

namespace ActionsTest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private BrowserDriver _browserDriver;
        private PageModel _pageModel;
        public Hooks(BrowserDriver browserDriver, PageModel pageModel)
        {
            _browserDriver = browserDriver;
            _pageModel = pageModel;

        }

        [BeforeScenario("@tag1")]
        public void BeforeScenario()
        {
            _pageModel.GoTo("https://www.saucedemo.com/");

            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}