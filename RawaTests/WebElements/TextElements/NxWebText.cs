using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RawaTests.WebElements.TextElements;

namespace RawaTests.IWebElements.TextElements
{
   public class NxWebText : BaseWebElement,INxWebText
    {
        private IWebElement element;
        public NxWebText(IWebElement e) : base(e)
        {
            element = e;
        }

        public bool Contains(string text)
        {
            return element.Text.Contains(text);
        }
    }
}
