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
    public class KlasaTestowa
    {
        private IWebDriver driver;
        public KlasaTestowa()
        {
            driver = new ChromeDriver();
        }

        [SetUp]
        public void TestInizialize()
        {

            //driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.ultimateqa.com/simple-html-elements-for-automation/");

        }
        [TearDown]
        public virtual void EndTest()
        {
            driver.Quit();
        }
        [Test]
        public void lalaasla()
        {
            driver.FindElement(By.XPath("//input[@value='other']")).Click();
            driver.FindElement(By.XPath("//input[@type='checkbox'][@value='Car']")).Click();
            var select = driver.FindElement(By.XPath("//select"));
            select.Click();
            select.FindElement(By.XPath("//option[@value='opel']")).Click();
            driver.FindElement(By.ClassName("et_pb_tab_1")).Click();
            var content = driver.FindElements(By.ClassName("et_pb_tab_content"));
            Assert.AreEqual("Tab 2 content", content[1].Text);

        }        
    }
}