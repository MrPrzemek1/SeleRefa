using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class SingleRowWithColorsWCModel
    {
        public IWebElement RowColors { get; set; }
        public SingleRowWithColorsWCModel(IWebElement rowColor)
        {
            RowColors = rowColor;
        }
    }
}
