using NUnit.Framework;
using OpenQA.Selenium;
using RawaTests.IWebElements;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Model.Base.Buttons
{
    public class NxButton : BaseWebElement, INxButton
    {
        private IWebElement element;
        public NxButton(IWebElement e) : base(e)
        {
            element = e;
        }
        
    }
 }
