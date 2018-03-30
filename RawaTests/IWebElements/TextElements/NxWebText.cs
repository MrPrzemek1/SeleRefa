using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RawaTests.IWebElements.TextElements
{
   public class NxWebText : BaseWebElement
    {
        private IWebElement element;
        public NxWebText()
        {
        }
        public NxWebText(IWebElement e) : base(e)
        {
            element = e;
        }
    }
}
