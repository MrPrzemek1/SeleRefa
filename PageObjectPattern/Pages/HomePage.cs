using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using PageFactory = SeleniumExtras.PageObjects.PageFactory;
using static PageObjectPattern.DriverHelper;
using OpenQA.Selenium.Chrome;

namespace PageObjectPattern.Pages
{
    public class HomePage
    {
        //private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//button[@class='btn btn-primary btn-lg btn-start']")]
        [CacheLookup]
        public IWebElement StartButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class' col-xs-10 title']")]
        [CacheLookup]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.ClassName, Using = "img-responsive")]
        [CacheLookup]
        public IWebElement HomeImage { get; set; }

        [FindsBy(How = How.ClassName, Using = "logo")]
        [CacheLookup]
        public IWebElement LogoImage { get; set; }

        [FindsBy(How = How.ClassName, Using = "link-login")]
        [CacheLookup]
        public IWebElement LoginLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class=' col-xs-12 footer-wraper']")]
        [CacheLookup]
        public IWebElement Footer { get; set; }

        public HomePage(IWebDriver driver)
        {
            driver = Driver;
            PageFactory.InitElements(Driver, );
        }

        public void ClickStartButton()
        {
            StartButton.Click();
        }
    }
}
