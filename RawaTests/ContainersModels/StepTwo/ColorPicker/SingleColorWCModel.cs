using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class SingleColorWCModel
    {
        public IWebElement SingleColor { get; set; }

        public SingleColorWCModel(IWebElement singleColor)
        {
            SingleColor = singleColor;
        }
    }
}
