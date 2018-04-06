using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace RawaTests.IWebElements
{
    public class BaseWebElement : IBaseWebElement
    {
        private IWebElement element;
        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
        public BaseWebElement(IWebElement e) => element = e;
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
    }
}

