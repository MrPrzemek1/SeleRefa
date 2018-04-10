using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Helpers.DriverHelper
{
    public static class DriverHelper
    {
        public static IList<IWebElement> FindWebElementsAndWait(IWebDriver Driver, By by, int second = 2)
        {
            IList<IWebElement> result = new List<IWebElement>();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(second));
            try
            {
                result = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
                result = Driver.FindElements(by);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }

        public static IList<IWebElement> FindWebElementsAndWait(IWebDriver Driver, IWebElement element, By by, int second = 2)
        {
            IList<IWebElement> result = new List<IWebElement>();
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(second));
            try
            {
                result = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
                result = element.FindElements(by);
            }
            catch (Exception)
            {
                result = null;
            }
            return result;
        }


        public static IWebElement FindWebElementAndWait(IWebDriver driver, By by, int second = 5)
        {
            var find = FindWebElementsAndWait(driver, by, second);
            if (find == null)
            {
                return null;
            }          
                return find.FirstOrDefault();
        }

        public static IWebElement FindWebElementAndWait(IWebDriver driver, IWebElement element, By by, int second = 5)
        {
            var find = FindWebElementsAndWait(driver, element, by, second);
            if (find == null)
            {
                return null;
            }
            return find.FirstOrDefault();
        }
    }
}


