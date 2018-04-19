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
        IWebElement FilterButton { get; set; }
        IWebElement FilterCabinetBodyColor { get; set; }
        IWebElement FilterFrontType { get; set; }

        public PanelCabinetFilterWCModel(IWebElement filterButton, IWebElement bodyColor, IWebElement frontType)
        {
            FilterButton = filterButton;
            FilterCabinetBodyColor = bodyColor;
            FilterFrontType = frontType;
        }
    }
}
