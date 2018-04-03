using OpenQA.Selenium;
using RawaTests.IWebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.WebElements.Input
{
     class NxInput : BaseWebElement, INxInput
    {
        private IWebElement element;
        private IList<IWebElement> listOfInput;
        public NxInput(IWebElement e) : base(e)
        {
            element = e;
        }
        public NxInput (IList<IWebElement> e) : base(e)
        {
            listOfInput = e;
        }
        public void Clear()
        {
            element.Clear();
        }

        public void SendText(string text)
        {
            element.SendKeys(text);
        }
        public IWebElement this[int index]
        {
            get
            {
                return listOfInput[index];
            }
            set
            {
                listOfInput[index] = value;
            }
        }
    }
}
