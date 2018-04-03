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
        private IList<IWebElement> listOfLabels;
        public NxWebText(IWebElement e) : base(e)
        {
            element = e;
        }
        public NxWebText(IList<IWebElement> e) : base(e)
        {
            listOfLabels = e;
        }
        public bool Contains(string text)
        {
            return element.Text.Contains(text);
        }
        public IWebElement this[int index]
        {
            get
            {
                return listOfLabels[index];
            }
            set
            {
                listOfLabels[index] = value;
            }
        }
    }
}
