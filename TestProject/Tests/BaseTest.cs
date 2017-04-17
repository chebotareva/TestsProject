using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            if (driver == null)
                return;
            driver.Quit();
            driver.Dispose();
        }
    }
}
