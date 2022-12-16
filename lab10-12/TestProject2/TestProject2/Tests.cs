using System;
using NUnit.Framework;
using OpenQA.Selenium;
<<<<<<< HEAD
using TestProject2;
=======
using TestProject2.Properties;
>>>>>>> dc1a70ca5a61aa8c4f965e66658dbe3d6cda3668

namespace TestProject2
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://vokladki.by");
            driver.Manage().Window.Maximize();
            
        
        }
        [Test]
        public void Test1()
        {
          
<<<<<<< HEAD
            PageObject pageObjectMenu = new PageObject(driver);
=======
            PageObjectMenu pageObjectMenu = new PageObjectMenu(driver);
>>>>>>> dc1a70ca5a61aa8c4f965e66658dbe3d6cda3668
            pageObjectMenu.dostavkaButtonClick();
            pageObjectMenu.CatalogButtonClick();
            pageObjectMenu.ContactsButtonClick();
            pageObjectMenu.KonstructorButtonClick();
            pageObjectMenu.SkidkiButtonClick();
            pageObjectMenu.AboutBrandButtonClick();
            pageObjectMenu.OPtButtonClick();
            pageObjectMenu.FAQButtonClick();
        }
    }
<<<<<<< HEAD

    public partial class PageObjectMenu
    {
        public PageObjectMenu(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
=======
>>>>>>> dc1a70ca5a61aa8c4f965e66658dbe3d6cda3668
}