using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RawaTests.WebElements.TextElements;
using static RawaTests.Helpers.DriverHelper.DriverHelp;
using static RawaTests.Helpers.DriverHelper.DriverHelp.Drivers;

namespace RawaTests.IWebElements.TextElements
{
    public class NxLabels : BaseWebElement, INxLabels
    {
        private IWebElement element;
        public NxLabels(IWebElement e) : base(e)
        {
            element = e;
        }
        public bool Contains(string text)
        {
            return element.Text.Contains(text);
        }
    }
}
