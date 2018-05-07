using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PageObjectPattern.Tests
{
    public abstract class BaseTest
    {
        private IWebDriver driver;
        public BaseTest()
        {
            driver = new ChromeDriver();
        }
        public BaseTest(IWebDriver driver) 
        {
            this.driver = driver;
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

    }
}
