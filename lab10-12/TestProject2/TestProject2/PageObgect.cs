using OpenQA.Selenium;

namespace TestProject2
{
    public class PageObject
    {

        IWebDriver _webDriver;

        public PageObject(IWebDriver driver)
        {
            this._webDriver = driver;
        }

        private readonly By CatalogButton = By.XPath("//a[text()='Каталог']");
        private readonly By KonstructorButton = By.XPath("//a[text()='Конструктор']");
        private readonly By AboutBrandButton = By.XPath("//a[text()='О бренде']");
        private readonly By ContactsButton = By.XPath("//a[text()='Контакты']");
        private readonly By SkidkiButton = By.XPath("//a[text()='Скидки']");
        private readonly By FAQButton = By.XPath("//a[text()='FAQ']");
        private readonly By OPtButton = By.XPath("//a[text()='ОПТ']");
        private readonly By dostavkaButton = By.XPath("//a[text()='Доставка']");


        public void CatalogButtonClick()
        {
            _webDriver.FindElement(CatalogButton).Click();
        }

        public void KonstructorButtonClick()
        {
            _webDriver.FindElement(KonstructorButton).Click();
        }

        public void AboutBrandButtonClick()
        {
            _webDriver.FindElement(AboutBrandButton).Click();
        }

        public void ContactsButtonClick()
        {
            _webDriver.FindElement(ContactsButton).Click();
        }

        public void SkidkiButtonClick()
        {
            _webDriver.FindElement(SkidkiButton).Click();
        }

        public void FAQButtonClick()
        {
            _webDriver.FindElement(FAQButton).Click();
        }

        public void OPtButtonClick()
        {
            _webDriver.FindElement(OPtButton).Click();
        }

        public void dostavkaButtonClick()
        {
            _webDriver.FindElement(dostavkaButton).Click();
        }
        //
    }
}