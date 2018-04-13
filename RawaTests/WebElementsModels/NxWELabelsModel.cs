using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RawaTests.WebElementsModels
{
    public class NxWELabelModel : NxBaseWebElementModel
    {
        private IWebElement element;
        public NxWELabelModel(IWebElement e) : base(e)
        {
            element = e;
        }
        public bool Contains(string text)
        {
            return element.Text.Contains(text);
        }
    }
}
