using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Managers;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using static RawaTests.Helpers.DriverHelper.DriverHelper;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.IWebElements
{
    public class BaseWebElement : IBaseWebElement
    {
        private IWebElement element;
        WebDriverWait wait = new WebDriverWait(DriverManager.CreateInstance().Driver, TimeSpan.FromSeconds(2));
        public BaseWebElement(IWebElement e)
        {
            element = e;
        }

        public BaseWebElement(IList<IWebElement> list) => list = new List<IWebElement>();

        public string Text => element.Text;

        public bool Dispalyed()
        {
            return element.Displayed;
        }

        public string GetAttribute(string attribute)
        {
            return element.GetAttribute(attribute);
        }
        public virtual void Click()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
        }

        public List<IWebElement> FindElementsAndWait(By by)
        {
            return DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, element, by).ToList();
        }
        public IWebElement FindElementAndWait(By by)
        {
            return DriverHelper.FindWebElementAndWait(DriverManager.CreateInstance().Driver, element, by);
        }

        public T FindElementAndWait<T>(By by) where T : BaseWebElement
        {
            var result = DriverHelper.FindWebElementAndWait(DriverManager.CreateInstance().Driver, element, by);

            return (T)Activator.CreateInstance(typeof(T), new object[] { result });
        }

        public List<T> FindElementsAndWait<T>(By by) where T : BaseWebElement
        {
            var result = DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, element, by);

            return result.Select(e => (T)Activator.CreateInstance(typeof(T), new object[] { e })).ToList();
        }
    }
}

