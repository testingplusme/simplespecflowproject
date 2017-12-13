using OpenQA.Selenium;

namespace SimpleDI.Helpers
{
    public class WebDriverHelper
    {
        private readonly IWebDriver driver;
        public WebDriverHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Maximize()
        {
            driver.Manage().Window.Maximize();
        }
    }
}
