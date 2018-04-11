using OpenQA.Selenium;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Extensions
{
    public static class WebElementExtension
    {
        public static IWebElement FindWebElementAndWait(this IWebElement e, By by)
        {
           return DriverHelper.FindWebElementAndWait(DriverManager.CreateInstance().Driver, by);
        }
        public static IList<IWebElement> FindWebElementsAndWait(this IWebElement e, By by)
        {
            return DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, by);
        }
        public static IWebElement FindElementWithoutWait(this IWebElement e, By by)
        {
            return DriverHelper.FindWebElementWithoutWait(e,by);
        }
        public static IList<IWebElement> FindElementsWithoutWait(this IWebElement e, By by)
        {
            return DriverHelper.FindWebElementsWithoutWait(e, by);
        }
    }
}
