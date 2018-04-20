using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.ActiveElement
{
    public class ActiveCabinetLeftTableWCModel
    {
        public IWebElement CabinetImageThumb { get; set; }
        public IWebElement CabinetDimensionLabel { get; set; }
        public IWebElement DeleteButton { get; set; }
        public IWebElement DetalisButton { get; set; }

        public ActiveCabinetLeftTableWCModel(IWebElement cabinetImageThumb, IWebElement cabinetDimensionLabel, IWebElement deleteButton, IWebElement detalisButton)
        {
            CabinetImageThumb = cabinetImageThumb;
            CabinetDimensionLabel = cabinetDimensionLabel;
            DeleteButton = deleteButton;
            DetalisButton = detalisButton;
        }
    }
}
