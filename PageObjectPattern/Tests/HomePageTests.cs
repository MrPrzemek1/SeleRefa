using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using PageObjectPattern.Pages;
using static PageObjectPattern.DriverHelper;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace PageObjectPattern.Tests
{
    [TestFixture]
    public class HomePageTests
    {
        HomePage homePage;
        //IWebDriver driver;
        public HomePageTests()
        {
            
        }
        [SetUp]
        public void SetUp()
        {
            Initialize();
            PageFactory.InitElements(Driver, new HomePage(Driver));

        }
        [TearDown]
        public void EndTest()
        {
            Quit();
        }
        [Test]
        public void TestMethod()
        {
            homePage.StartButton.Click();
        }
    }
}
