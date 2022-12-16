using OpenQA.Selenium;

namespace TestProject2
{
    internal class PageObjectMenu
    {
        private IWebDriver driver;

        public PageObjectMenu(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}