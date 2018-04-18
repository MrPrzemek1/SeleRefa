using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.Helpers.DriverHelper;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests
{
    public static class WebElementExtension
    {
        public static IList<IWebElement> FindWebElementsAndWait(this IWebElement element, By by)
        {
            return DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, element, by);
        }

        public static IWebElement FindWebElementAndWait(this IWebElement element, By by)
        {
            return DriverHelper.FindWebElementAndWait(DriverManager.CreateInstance().Driver, element, by);
        }

        public static IList<IWebElement> FindWebElements(this IWebElement element, By by)
        {
            return DriverHelper.FindWebElementsWithoutWait(element, by);
        }

        public static IWebElement FindWebElement(this IWebElement element, By by)
        {
            return DriverHelper.FindWebElementWithoutWait(element, by);
        }

        public static string GetAttributeSrc(this IWebElement element)
        {
            return element.GetAttribute(HtmlAttributesConsts.SRC);
        }

        public static void ClickIfElementIsClickable(this IWebElement e)
        {
            DriverHelper.WaitUntil(DriverManager.CreateInstance().Driver, ExpectedConditions.ElementToBeClickable(e));
        }

    }
}
