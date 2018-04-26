﻿using OpenQA.Selenium;
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
        public static IList<IWebElement> FindWebElementsAndWait(this IWebElement element,IWebDriver driver, By by)
        {
            return DriverHelper.FindWebElementsAndWait(driver, element, by);
        }

        public static IWebElement FindWebElementAndWait(this IWebElement element, IWebDriver driver, By by)
        {
            return DriverHelper.FindWebElementAndWait(driver, element, by);
        }

        public static IList<IWebElement> FindWebElements(this IWebElement element, IWebDriver driver, By by)
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

        public static void ClickIfElementIsClickable(this IWebElement e,IWebDriver driver)
        {
            DriverHelper.WaitUntil(driver, ExpectedConditions.ElementToBeClickable(e)).Click();
        }

    }
}
