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
       public IWebElement ColorSquare { get; set; }
       public IWebElement CancelButton { get; set; }
       public IWebElement SubmitButton { get; set; }
       public ColorSliderWCModel ColorSlider { get; set; }

        public RightPanelColorPickerWCModel(IWebElement colorSquare, IWebElement cancelButton, IWebElement submitButton, ColorSliderWCModel colorSlider)
        {
            ColorSquare = colorSquare;
            CancelButton = cancelButton;
            SubmitButton = submitButton;
            ColorSlider = colorSlider;
        }
        public void ChangeColorWithSquare()
        {
            Actions actions = new Actions(DriverManager.CreateInstance().Driver);
            actions.ClickAndHold(ColorSquare)
                .MoveByOffset(25, 15)
                .Release()
                .Build()
                .Perform();
        }
    }
}
