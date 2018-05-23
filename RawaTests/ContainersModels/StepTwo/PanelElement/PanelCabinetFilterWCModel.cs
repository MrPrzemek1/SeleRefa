using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    public class PanelCabinetFilterWCModel
    {
        public IWebElement filterButton { get; set; }
        public IWebElement filterCabinetBodyColor { get; set; }
        public IWebElement filterFrontType { get; set; }

        public PanelCabinetFilterWCModel(IWebElement filterButton, IWebElement filterCabinetBodyColor, IWebElement filterFrontType)
        {
            this.filterButton = filterButton;
            this.filterCabinetBodyColor = filterCabinetBodyColor;
            this.filterFrontType = filterFrontType;
        }
    }
}
