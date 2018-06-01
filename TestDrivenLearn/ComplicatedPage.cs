using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace TestDrivenLearn
{
    internal class ComplicatedPage
    {
        IWebDriver Driver { get; set; }
        public ComplicatedPage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void Open()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/complicated-page/");
            Driver.Manage().Window.Maximize();
        }

        internal AmazonSearchPage SearchUsingAmazon(string textToSearch)
        {
            IWebElement searchBar = Driver.FindElement(By.ClassName("amzn-native-search"));
            searchBar.SendKeys(textToSearch);
            Driver.FindElement(By.ClassName("amzn-native-search-go")).Click();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            return new AmazonSearchPage(Driver);
        }
    }
}