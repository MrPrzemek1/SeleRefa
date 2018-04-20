﻿using System;
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
        public IWebElement NameGropuOfCabinetsButton { get; set; }
        public IWebElement OpenGroupCabinets { get; set; }
        public IWebElement ClosedGroupCabintes { get; set; }
        public IWebElement ImagesOfCabinets { get; set; }

        public PanelCabinetsCollectionWCModel(IWebElement nameGroupButton, IWebElement openCabinets, IWebElement closedCabinets, IWebElement imagesCabinets)
        {
            this.NameGropuOfCabinetsButton = nameGroupButton;
            this.OpenGroupCabinets = openCabinets;
            this.ClosedGroupCabintes = closedCabinets;
            this.ImagesOfCabinets = imagesCabinets;
        }
    }
}