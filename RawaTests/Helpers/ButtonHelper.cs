using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Helpers
{
    public class ButtonHelper
    {  
        public static void ClickButtonNext()
        {
            var buttonNext = DriverManager.CreateInstance().WaiTUntil(ExpectedConditions.ElementIsVisible(By.XPath(StaticButtons.ButtonNext)));
            buttonNext.Click();
        }
        public static void ClickButtonPrev()
        {
            var ButtonPrev = DriverManager.CreateInstance().WaiTUntil(ExpectedConditions.ElementIsVisible(By.XPath(StaticButtons.ButtonPrev)));
            ButtonPrev.Click();
        }
    }
}
