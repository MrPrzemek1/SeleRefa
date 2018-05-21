using OpenQA.Selenium;
using RawaTests.Managers;

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
