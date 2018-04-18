using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    public class PanelListCabinetsFilterWCModel
    {
        IWebElement FiltrPanel { get; set; }
        IList<IWebElement> FiltrDropown { get; set; }

        public PanelListCabinetsFilterWCModel(IWebElement filtrPanel, IList<IWebElement> filtrDropdown)
        {
            FiltrPanel = filtrPanel;
            FiltrDropown = filtrDropdown;
        }
    }
}
