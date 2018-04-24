using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class ColorSliderWCModel
    {
        public IWebElement ColorColumn { get; set; }
        public IWebElement ColorSlider { get; set; }

        public ColorSliderWCModel(IWebElement colorColumn, IWebElement colorSlider)
        {
            ColorColumn = colorColumn;
            ColorSlider = colorSlider;
        }
        public void ChangeColorWithSlider(int yPosition)
        {
            Actions actions = new Actions(DriverManager.CreateInstance().Driver);
            actions.ClickAndHold(ColorSlider)
                .MoveByOffset(0, yPosition)
                .Release()
                .Build()
                .Perform();
        }
    }
}
