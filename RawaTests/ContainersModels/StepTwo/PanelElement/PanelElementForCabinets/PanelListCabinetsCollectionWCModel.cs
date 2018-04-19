using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RawaTests.Helpers;
using RawaTests.Managers;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    class PanelCabinetsCollectionWCModel
    {
        IWebElement NameGropuOfCabinetsButton { get; set; }
        IWebElement OpenGroupCabinets { get; set; }
        IWebElement ClosedGroupCabintes { get; set; }
        IWebElement ImagesOfCabinets { get; set; }

        public PanelCabinetsCollectionWCModel(IWebElement nameGroupButton, IWebElement openCabinets, IWebElement closedCabinets, IWebElement imagesCabinets)
        {
            this.NameGropuOfCabinetsButton = nameGroupButton;
            this.OpenGroupCabinets = openCabinets;
            this.ClosedGroupCabintes = closedCabinets;
            this.ImagesOfCabinets = imagesCabinets;
        }
        public void GetOpenedGroupOfCabinets()
        {
            ClosedGroupCabintes.ClickIfElementIsClickable();
        }
        public void GetClosedGroupOfCabinets()
        {
            ClosedGroupCabintes.ClickIfElementIsClickable();
        }
        public void ExpandCabinetsGroup()
        {
            NameGropuOfCabinetsButton.ClickIfElementIsClickable();
        }
        public IWebElement GetImage()
        {
            return this.ImagesOfCabinets;
        }


    }
}
