using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PageObjectPattern.Tests
{
    [SetUpFixture, Category("Rawa"),]
    public abstract class BaseTest
    {
        private IWebDriver driver;
        public BaseTest()
        {

        }
        public BaseTest(IWebDriver driver) 
        {
            this.driver = driver;
        }
        [OneTimeSetUp]
        public virtual void TestInizialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://interactjs.io/");

        }
        [OneTimeTearDown]
        public virtual void EndTest()
        {
            driver.Quit();
        }
    }
}
