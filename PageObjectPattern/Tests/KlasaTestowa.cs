using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using PageObjectPattern.Pages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static PageObjectPattern.DriverHelper;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace PageObjectPattern.Tests
{ 
    [TestFixture]
   // [Parallelizable]
    public class KlasaTestowa : BaseTest
    {
        public KlasaTestowa() : base()
        {

        }
        private IWebDriver driver;
        public KlasaTestowa(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }
        [Test]
        [TestCaseSource("BrowserType")]
        public void lalaasla(String browser)
        {
            TestInizialize(browser);

            driver.FindElement(By.XPath("//html//div[2]/label[4]")).Click();
            Thread.Sleep(2000);
            Actions actions = new Actions(driver);
            var source = driver.FindElement(By.XPath("//div[@id='yes-drop']"));
            var target = driver.FindElement(By.XPath("//div[@id='inner-dropzone']"));
            actions.DragAndDropToOffset(source, 804, 769).Perform();
            actions.DragAndDrop(source, target).Perform() ;
        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
        public static IEnumerable<String> BrowserType()
        {
           String[] browsers = {"chrome", "firefox", "ie"};
            foreach (var item in browsers)
            {
                yield return item;
            }
        }
    }
}