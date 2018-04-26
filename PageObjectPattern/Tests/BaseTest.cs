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
        public virtual void TestInizialize(string browser)
        {
            if (browser.Equals("chrome"))
            {
                driver = new ChromeDriver();
            }
            else if (browser.Equals("firefox"))
            {
                driver = new FirefoxDriver();
            }
            else if (browser.Equals("ie"))
            {
                driver = new InternetExplorerDriver();
            }
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
