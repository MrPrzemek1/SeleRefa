using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestDrivenLearn
{
    internal class AmazonSearchPage
    {
        private IWebDriver driver;

        public AmazonSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string AmazonSearchResult
        {
            get
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("")));
                return element.Text;
            }
        }
    }
}