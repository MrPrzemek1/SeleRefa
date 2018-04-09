using OpenQA.Selenium;
using RawaTests.IWebElements;
using RawaTests.Model.Base.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawaTests.Helpers.DriverHelper.DriverHelp;

namespace RawaTests.Helpers
{
    public class WebElementHelper
    {

        public static IBaseWebElement GetElementButton(By by)
        {
            try
            {
               IWebElement element = Driver.FindElement(by);
               return new NxButton(element);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
