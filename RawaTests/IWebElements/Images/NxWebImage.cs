using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.IWebElements
{
    public class NxWebImage : BaseWebElement, INxWebImage
    {
        private IWebElement element;

        public NxWebImage(IWebElement element) : base (element)
        {
            this.element = element;
        }

        public string GetImageSource()
        {
            return element.GetAttribute("src");
        }
    }
}
