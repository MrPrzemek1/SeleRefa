using OpenQA.Selenium;
using RawaTests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.Base
{
    public class CustomWebElement
    {
        public IWebElement Element { get; set; }

        public CustomWebElement(IWebElement element)
        {
            Element = element;
        }

        public string Style { get { return Element.GetAttribute(HTMLConsts.STYLE); } }

        public string Class { get { return Element.GetAttribute(HTMLConsts.CLASS); } }


    }
}
