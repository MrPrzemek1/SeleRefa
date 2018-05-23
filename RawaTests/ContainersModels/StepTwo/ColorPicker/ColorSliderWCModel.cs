using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class ColorSliderWCModel
    {
        private IWebDriver _driver;
        public IWebElement colorColumn { get; set; }
        public IWebElement colorSlider { get; set; }

        public ColorSliderWCModel(IWebDriver driver, IWebElement colorColumn, IWebElement colorSlider)
        {
            this._driver = driver;
            this.colorColumn = colorColumn;
            this.colorSlider = colorSlider;
        }
        public void ChangeColorWithSlider(int yPosition)
        {
            Actions actions = new Actions(_driver);
            actions.ClickAndHold(colorSlider)
                .MoveByOffset(0, yPosition)
                .Release()
                .Build()
                .Perform();
        }
    }
}
