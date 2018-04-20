using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    public class PanelCabinetFilterWCModel
    {
        public IWebElement FilterButton { get; set; }
        public IWebElement FilterCabinetBodyColor { get; set; }
        public IWebElement FilterFrontType { get; set; }

        public PanelCabinetFilterWCModel(IWebElement filterButton, IWebElement bodyColor, IWebElement frontType)
        {
            FilterButton = filterButton;
            FilterCabinetBodyColor = bodyColor;
            FilterFrontType = frontType;
        }
    }
}
