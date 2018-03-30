using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.IWebElements
{
    public class NxWebImage : INxWebImage
    {
        private IWebElement element;

        public NxWebImage()
        {
        }

        public NxWebImage(IWebElement element)
        {
            this.element = element;
        }

        public string Source => element.GetAttribute("src");
    }
}
