using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelper;

namespace RawaTests.IWebElements
{
    public class NxImage : BaseWebElement, INxImage
    {

        private IWebElement element;
        public NxImage(IWebElement element) : base (element)
        {
            this.element = element;
        }
        public string GetImageSource()
        {
            return element.GetAttribute("src");
        }
        public string GetElementAttribute(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }
        public override void Click()
        {
            element.Click();           
        }
    }
}
