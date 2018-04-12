using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using PageObjectPattern.Pages;
using static PageObjectPattern.DriverHelper;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace PageObjectPattern.Tests
{
    [TestFixture]   
    public class HomePageTests
    {
        
        private IWebDriver driver;
        //IWebDriver driver;
        public HomePageTests()
        {
            
        }
        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://demo.net-art.eu/konfigurator3d");
        }
        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}