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
        public static void ClickButtonNext()
        {
            var buttonNext = DriverHelper.DriverHelper.WaitUntil(DriverManager.CreateInstance().Driver,ExpectedConditions.ElementIsVisible(By.XPath(StaticButtons.ButtonNext)));
            buttonNext.ClickIfElementIsClickable();
        }
        public static void ClickButtonPrev()
        {
            var ButtonPrev = DriverHelper.DriverHelper.WaitUntil(DriverManager.CreateInstance().Driver, ExpectedConditions.ElementIsVisible(By.XPath(StaticButtons.ButtonPrev)));
            ButtonPrev.ClickIfElementIsClickable();
        }
    }
}
