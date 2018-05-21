using OpenQA.Selenium;

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
