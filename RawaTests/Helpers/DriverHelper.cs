using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Linq;
using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements;
using RawaTests.Managers;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.Helpers.DriverHelper
{
    public static class DriverHelper
    {
        public static IList<IWebElement> FindWebElementsAndWait(IWebDriver Driver, By by, int second = 5)
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

        public static IList<IWebElement> FindWebElementsAndWait(IWebDriver Driver, IWebElement element, By by, int second = 5)
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
            return FindWebElementsAndWait(driver, by, second).FirstOrDefault();
        }

        public static IWebElement FindWebElementAndWait(IWebDriver driver, IWebElement element, By by, int second = 5)
        {
            return FindWebElementsAndWait(driver, element, by, second).FirstOrDefault();
        }
    }
}


