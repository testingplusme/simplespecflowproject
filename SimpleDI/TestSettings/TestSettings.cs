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

        public TestSettings(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {
           var driver = new ChromeDriver();
           objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
           var driver = objectContainer.Resolve<IWebDriver>();
           driver.Close();
           objectContainer.Dispose();
        }
    }
}
