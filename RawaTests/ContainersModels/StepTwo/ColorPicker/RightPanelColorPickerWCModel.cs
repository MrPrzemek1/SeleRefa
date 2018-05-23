using OpenQA.Selenium;
using RawaTests.Managers;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class RightPanelColorPickerWCModel
    {
       private IWebDriver _driver;
       public IWebElement colorSquare { get; set; }
       public IWebElement cancelButton { get; set; }
       public IWebElement submitButton { get; set; }
       public ColorSliderWCModel colorSlider { get; set; }

        public RightPanelColorPickerWCModel(IWebDriver driver, IWebElement colorSquare, IWebElement cancelButton, IWebElement submitButton, ColorSliderWCModel colorSlider)
        {
            this._driver = driver;
            this.colorSquare = colorSquare;
            this.cancelButton = cancelButton;
            this.submitButton = submitButton;
            this.colorSlider = colorSlider;
        }
        public void ChangeColorWithSquare()
        {
            ActionManager.Create(_driver).

            ClickAndHold(colorSquare)
                .MoveByOffset(25, 15)
                .Release()
                .Build()
                .Perform();
        }
    }
}
