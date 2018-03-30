using OpenQA.Selenium;
using RawaTests.IWebElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Model.Base.Buttons
{
    public class NxButton : BaseWebElement, INxButton
    {
        private IWebElement element;
        public NxButton()
        {

        }
        public NxButton(IWebElement e) : base(e)
        {
            element = e;
        }
        public void Click()
        {
            element.Click();
        }
    }
}
