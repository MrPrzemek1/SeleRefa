﻿using OpenQA.Selenium;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    class PanelCabinetsCollectionWCModel
    {
        public IWebElement NameGropuOfCabinetsButton { get; set; }
        public IWebElement OpenGroupCabinets { get; set; }
        public IWebElement ClosedGroupCabintes { get; set; }
        public IWebElement ImagesOfCabinets { get; set; }

        public PanelCabinetsCollectionWCModel(IWebElement nameGroupButton, IWebElement openCabinets, IWebElement closedCabinets, IWebElement imagesCabinets)
        {
            NameGropuOfCabinetsButton = nameGroupButton;
            OpenGroupCabinets = openCabinets;
            ClosedGroupCabintes = closedCabinets;
            ImagesOfCabinets = imagesCabinets;
        }
    }
}
