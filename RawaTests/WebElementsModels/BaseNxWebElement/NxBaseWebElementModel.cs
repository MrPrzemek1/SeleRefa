using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RawaTests.Helpers.DriverHelper;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.WebElementsModels
{
    public class NxBaseWebElementModel
    {
        private IWebElement element;
        WebDriverWait wait;
        public NxBaseWebElementModel(IWebElement e)
        {
            element = e;
        }

        public NxBaseWebElementModel(IList<IWebElement> list) => list = new List<IWebElement>();

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
        public IWebElement GetIWebElementElement()
        {
            return element;
        }

        public string GetAttribute(string attribute)
        {
            return element.GetAttribute(attribute);
        }
        public virtual void Click()
        {
            DriverManager.CreateInstance().WaiTUntil(ExpectedConditions.ElementToBeClickable(element)).Click();
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

        public T FindElementAndWait<T>(By by) where T : NxBaseWebElementModel
        {
            var result = DriverHelper.FindWebElementAndWait(DriverManager.CreateInstance().Driver, element, by);

            return (T)Activator.CreateInstance(typeof(T), new object[] { result });
        }

        public List<T> FindElementsAndWait<T>(By by) where T : NxBaseWebElementModel
        {
            var result = DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, element, by);

            return result.Select(e => (T)Activator.CreateInstance(typeof(T), new object[] { e })).ToList();
        }

        public List<TInterface> FindElementsAndWait<TClass, TInterface>(By by) 
            where TClass : NxBaseWebElementModel 
            where TInterface : IBaseWebElement
        {
            var result = DriverHelper.FindWebElementsAndWait(DriverManager.CreateInstance().Driver, element, by);

            var models = result.Select(e => (TClass)Activator.CreateInstance(typeof(TClass), new object[] { e }));

            return models.Cast<TInterface>().ToList();
        }
    }
}

