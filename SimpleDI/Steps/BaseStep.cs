using BoDi;
using OpenQA.Selenium;

namespace SimpleDI.Steps
{
    public class BaseStep
    {
        public readonly IObjectContainer objectContainer;
        public IWebDriver WebDriver => objectContainer.Resolve<IWebDriver>();

        public BaseStep(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }
    }
}
