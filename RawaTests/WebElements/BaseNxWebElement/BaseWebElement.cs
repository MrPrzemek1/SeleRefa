using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.IWebElements
{
    public class BaseWebElement : IBaseWebElement
    {
        private IWebElement element;
        WebDriverWait wait;
        public BaseWebElement(IWebElement e)
        {
            element = e;
        }

        public BaseWebElement(IList<IWebElement> list) => list = new List<IWebElement>();

        public string Text => element.Text;

        public bool Dispalyed()
        {
            bool result = true;
            try
            {
                result = element.Displayed;               
            }
            catch (Exception)
            {
                return false;
            }
            return result;
        }

        public string GetAttribute(string attribute)
        {
            return element.GetAttribute(attribute);
        }
        public virtual void Click()
        {
            wait = new WebDriverWait(DriverManager.CreateInstance().Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
        }

        public List<IWebElement> FindElementsAndWait(By by)
        {
            return DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, element, by).ToList();
        }
        public IWebElement FindElementAndWait(By by)
        {
            var find = DriverHelper.FindWebElementAndWait(DriverManager.CreateInstance().Driver, element, by);
            if (find==null)
            {
                return null;
            }
            return find;
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

