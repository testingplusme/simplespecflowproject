using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SimpleDI.Helpers;
using TechTalk.SpecFlow;

namespace SimpleDI.TestSettings
{
    [Binding]
    public sealed class TestSettings
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver WebDriver;
        private WebDriverHelper webDriverHelper;
        private readonly ScenarioContext scenarioContext;

        public TestSettings(IObjectContainer objectContainer,ScenarioContext scenario)
        {
            this.objectContainer = objectContainer;
            this.scenarioContext = scenario;
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            WebDriver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
           WebDriver.Close();
           WebDriver.Dispose();
           objectContainer.Dispose();
        }
    }
}
