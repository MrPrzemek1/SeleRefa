,using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;

namespace PageObjectPattern.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver)
        {
           _driver = driver;
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "button1")]
        private IWebElement ClickMe;

        [FindsBy(How = How.Id, Using = "button2")]
        private IWebElement Raise;
        public void ClickStartButton()
        {
            ClickMe.Click();
        }
    }
}
