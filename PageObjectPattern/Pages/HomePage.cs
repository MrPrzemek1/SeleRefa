using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace PageObjectPattern.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn-primary btn-lg btn-start']")]
        private IWebElement StartButton { get { return driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-lg btn-start']")); } }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn-primary btn-lg btn-start']")]
        private IWebElement LoginButton { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickStartButton()
        {
            LoginButton.Click();
        }
    }
}
