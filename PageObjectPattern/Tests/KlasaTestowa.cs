using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectPattern.Pages;
using System;

namespace PageObjectPattern.Tests
{
    [TestFixture]
    public class KlasaTestowa : BaseTest
    {
        private IWebDriver driver;

        public KlasaTestowa()
        {
        }

        [SetUp]
        public void TestInizialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }
        [TearDown]
        public virtual void EndTest()
        {
            driver.Quit();
        }
        [Test]     
        public void lalaasla()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickStartButton();
        }        
    }
}