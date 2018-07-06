using OpenQA.Selenium;
using RawaTests.Helpers.DriverHelper;
using System.Collections.Generic;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests
{
    public static class WebElementExtension
    {
        public static IList<IWebElement> FindWebElementsAndWait(this IWebElement element,IWebDriver driver, By by)
        {
            return DriverHelper.FindWebElementsAndWait(driver, element, by);
        }

        public static IWebElement FindWebElementAndWait(this IWebElement element, IWebDriver driver, By by)
        {
            return DriverHelper.FindWebElementAndWait(driver, element, by);
        }

        public static IWebElement FindWebElement(this IWebElement element, By by)
        {
            return DriverHelper.FindWebElementWithoutWait(element, by);
        }

        public static IList<IWebElement> FindWebElements(this IWebElement element, IWebDriver driver, By by)
        {
            return DriverHelper.FindWebElementsWithoutWait(element, by);
        }

        public static void ClickIfElementIsClickable(this IWebElement e, IWebDriver driver)
        {
            DriverHelper.WaitUntil(driver, ExpectedConditions.ElementToBeClickable(e)).Click();
        }

    }
}
