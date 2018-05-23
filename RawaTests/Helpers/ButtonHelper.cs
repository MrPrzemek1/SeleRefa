using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using RawaTests.Helpers.DriverHelper;

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
            var buttonPrev = DriverHelper.DriverHelper.WaitUntil(driver, ExpectedConditions.ElementIsVisible(By.XPath(StaticButtonsConsts.ButtonPrev)));
            buttonPrev.ClickIfElementIsClickable(driver);
        }
    }
}
