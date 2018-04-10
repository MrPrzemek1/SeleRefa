using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using static PageObjectPattern.DriverHelper;
using OpenQA.Selenium.Chrome;

namespace PageObjectPattern.Pages
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary btn-lg btn-start']")]
        private IWebElement StartButton { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickStartButton()
        {
            StartButton.Click();
        }
    }
}
