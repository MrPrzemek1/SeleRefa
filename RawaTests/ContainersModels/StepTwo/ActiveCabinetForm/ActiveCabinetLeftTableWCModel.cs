using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.ActiveElement
{
    public class ActiveCabinetLeftTableWCModel
    {
        public IWebElement cabinetImageThumb { get; set; }
        public IWebElement cabinetDimensionLabel { get; set; }
        public IWebElement deleteButton { get; set; }
        public IWebElement detalisButton { get; set; }

        public ActiveCabinetLeftTableWCModel(IWebElement cabinetImageThumb, IWebElement cabinetDimensionLabel, IWebElement deleteButton, IWebElement detalisButton)
        {
            this.cabinetImageThumb = cabinetImageThumb;
            this.cabinetDimensionLabel = cabinetDimensionLabel;
            this.deleteButton = deleteButton;
            this.detalisButton = detalisButton;
        }
    }
}
