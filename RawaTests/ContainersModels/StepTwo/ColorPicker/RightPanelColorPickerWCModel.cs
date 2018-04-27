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
    public class RightPanelColorPickerWCModel
    {
       private IWebDriver Driver;
       public IWebElement ColorSquare { get; set; }
       public IWebElement CancelButton { get; set; }
       public IWebElement SubmitButton { get; set; }
       public ColorSliderWCModel ColorSlider { get; set; }

        public RightPanelColorPickerWCModel(IWebDriver driver, IWebElement colorSquare, IWebElement cancelButton, IWebElement submitButton, ColorSliderWCModel colorSlider)
        {
            this.Driver = driver;
            ColorSquare = colorSquare;
            CancelButton = cancelButton;
            SubmitButton = submitButton;
            ColorSlider = colorSlider;
        }
        public void ChangeColorWithSquare()
        {
            ActionManager.Create(Driver).

            ClickAndHold(ColorSquare)
                .MoveByOffset(25, 15)
                .Release()
                .Build()
                .Perform();
        }
    }
}
