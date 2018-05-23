using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    class PanelCabinetsCollectionWCModel
    {
        public IWebElement nameGropuOfCabinetsButton { get; set; }
        public IWebElement openGroupCabinets { get; set; }
        public IWebElement closedGroupCabintes { get; set; }
        public IWebElement imagesOfCabinets { get; set; }

        public PanelCabinetsCollectionWCModel(IWebElement nameGroupButton, IWebElement openCabinets, IWebElement closedCabinets, IWebElement imagesCabinets)
        {
            this.nameGropuOfCabinetsButton = nameGroupButton;
            this.openGroupCabinets = openCabinets;
            this.closedGroupCabintes = closedCabinets;
            this.imagesOfCabinets = imagesCabinets;
        }
    }
}
