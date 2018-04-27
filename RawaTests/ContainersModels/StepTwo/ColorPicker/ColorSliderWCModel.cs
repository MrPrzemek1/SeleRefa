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
        private IWebDriver Driver;
        public ColorSliderWCModel(IWebDriver driver, IWebElement colorColumn, IWebElement colorSlider)
        {
            this.Driver = driver;
            ColorColumn = colorColumn;
            ColorSlider = colorSlider;
        }
        public void ChangeColorWithSlider(int yPosition)
        {
            Actions actions = new Actions(Driver);
            actions.ClickAndHold(ColorSlider)
                .MoveByOffset(0, yPosition)
                .Release()
                .Build()
                .Perform();
        }
    }
}
