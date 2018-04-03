using OpenQA.Selenium;
using RawaTests.IWebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.WebElements.Input
{
     class NxInput : BaseWebElement, IWebNxButton
    {
        private IWebElement element;
        public NxInput(IWebElement e) : base(e)
        {
            element = e;
        }

        public void Clear()
        {
            element.Clear();
        }

        public void SendText(string text)
        {
            element.SendKeys(text);
        }
        
    }
}
