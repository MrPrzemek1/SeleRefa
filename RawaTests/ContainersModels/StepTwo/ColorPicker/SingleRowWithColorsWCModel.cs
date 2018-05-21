using OpenQA.Selenium;

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
