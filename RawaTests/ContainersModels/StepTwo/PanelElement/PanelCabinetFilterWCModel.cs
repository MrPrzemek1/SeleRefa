using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    public class PanelCabinetFilterWCModel
    {
        public IWebElement FilterButton { get; set; }
        public IWebElement FilterCabinetBodyColor { get; set; }
        public IWebElement FilterFrontType { get; set; }

        public PanelCabinetFilterWCModel(IWebElement filterButton, IWebElement filterCabinetBodyColor, IWebElement filterFrontType)
        {
            FilterButton = filterButton;
            FilterCabinetBodyColor = filterCabinetBodyColor;
            FilterFrontType = filterFrontType;
        }
    }
}
