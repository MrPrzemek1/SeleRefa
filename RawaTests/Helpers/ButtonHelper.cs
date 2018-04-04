using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base.Buttons;
using System;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Helpers
{
    public class ButtonHelper
    {

        public static void ClickButtonNext()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var buttonNext = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(StaticButtons.ButtonNext)));
            buttonNext.Click();
        }
        public static void ClickButtonPrev()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var ButtonPrev = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(StaticButtons.ButtonPrev)));
            ButtonPrev.Click();
        }
    }
}
