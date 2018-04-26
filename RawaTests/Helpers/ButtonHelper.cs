using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using RawaTests.Helpers;

namespace RawaTests.Helpers
{
    public class ButtonHelper
    {  
        public static void ClickButtonNext(IWebDriver driver)
        {
            var buttonNext = DriverHelper.DriverHelper.WaitUntil(driver,ExpectedConditions.ElementIsVisible(By.XPath(StaticButtonsConsts.ButtonNext)));
            buttonNext.ClickIfElementIsClickable(driver);
        }
        public static void ClickButtonPrev(IWebDriver driver)
        {
            var ButtonPrev = DriverHelper.DriverHelper.WaitUntil(driver, ExpectedConditions.ElementIsVisible(By.XPath(StaticButtonsConsts.ButtonPrev)));
            ButtonPrev.ClickIfElementIsClickable(driver);
        }
    }
}
