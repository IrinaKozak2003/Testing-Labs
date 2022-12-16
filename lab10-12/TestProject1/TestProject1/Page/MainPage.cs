using System;
using OpenQA.Selenium;

namespace TestProject1.Page
{
    public class MainPage
    {
        private IWebDriver driver;
        private readonly By CatalogButton = By.XPath("//a[text()='Каталог']");
        private readonly By KonstructorButton = By.XPath("//a[text()='Конструктор']");
        private readonly By AboutBrandButton = By.XPath("//a[text()='О бренде']");
        private readonly By ContactsButton = By.XPath("//a[text()='Контакты']");
        private readonly By SkidkiButton = By.XPath("//a[text()='Скидки']");
        private readonly By FAQButton = By.XPath("//a[text()='FAQ']");
        private readonly By OPtButton = By.XPath("//a[text()='Опт']");
        private readonly By dostavkaButton = By.XPath("//a[text()='Доставка']");
        private readonly By SearchButton = By.XPath("//span[@class='search']");
        private readonly By SearchInput = By.XPath("//input[@name='search']");
        private readonly By SearchResult = By.XPath("//h5[b[text()='1. ']]");
        private readonly By MenuResult = By.XPath("//div[text()='Рюкзак:']");
        
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public String ClickCatalogButton()
        {
            driver.FindElement(CatalogButton).Click();
            return driver.FindElement(MenuResult).Text;

        }
        public void ClickKonstructorButton()
        {
            driver.FindElement(KonstructorButton).Click();
        }
        public void ClickAboutBrandButton()
        {
            driver.FindElement(AboutBrandButton).Click();
        }
        public void ClickContactsButton()
        {
            driver.FindElement(ContactsButton).Click();
        }
        public void ClickSkidkiButton()
        {
            driver.FindElement(SkidkiButton).Click();
        }
        public void ClickFAQButton()
        {
            driver.FindElement(FAQButton).Click();
        }
        public void ClickOPtButton()
        {
            driver.FindElement(OPtButton).Click();
        }
        public void ClickdostavkaButton()
        {
            driver.FindElement(dostavkaButton).Click();
        }
        public void ClickAllButtons()
        {
            ClickCatalogButton();
            ClickKonstructorButton();
            ClickAboutBrandButton();
            ClickContactsButton();
            ClickSkidkiButton();
            ClickFAQButton();
            ClickOPtButton();
            ClickdostavkaButton();
        }
        
        public String Search(Models.Search search)
        {
            driver.FindElement(SearchButton).Click();
            driver.FindElement(SearchInput).SendKeys(search._searchString);
            driver.FindElement(SearchInput).SendKeys(Keys.Enter);
            return driver.FindElement(SearchResult).Text;
        }
    }
}