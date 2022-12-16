using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TestProject1.Driver;
using TestProject1.Models;
using TestProject1.Page;
using TestProject1.Service;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = DriverSingelton.GetDriver();
            driver.Navigate().GoToUrl("https://vokladki.by/");
            //driver.Manage().Window.Maximize();
            
        }
        private String _SearchText = "Рюкзак:";
        private String _SearchText2 = "Поиск";
        [Test]
        public void Test1()
        {
            MainPage mainPage = new MainPage(driver);
            //mainPage.Search(SearchCreate.CreateSearchWithCredentialsString());
            Assert.True(mainPage.Search(SearchCreate.CreateSearchWithCredentialsString()).Contains(_SearchText));
        }
        [Test]
        public void Test2()
        {
            MainPage mainPage = new MainPage(driver);
            //mainPage.Search(SearchCreate.CreateSearchWithCredentialsString());
           // mainPage.ClickdostavkaButton();
            Assert.AreEqual(mainPage.ClickCatalogButton(), "Рюкзак:");
            
        }
        [Test]
        public void Test3()
        {
            MainPage mainPage = new MainPage(driver);
            //mainPage.Search(SearchCreate.CreateSearchWithCredentialsString());
            Assert.True(mainPage.Search(SearchCreate.CreateSearchWithEmptyString()).Contains(_SearchText2));
        }
    }
}