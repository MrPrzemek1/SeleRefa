using OpenQA.Selenium;
using RawaTests.WebElementsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.PanelElement
{
    public class PanelListCabinetsFilterWCModel
    {
        NxWELabelModel FiltrPanel { get; set; }
        IList<NxWEButtonModel> FiltrDropown { get; set; }

        public PanelListCabinetsFilterWCModel(NxWELabelModel filtrPanel, List<NxWEButtonModel> filtrDropdown)
        {
            FiltrPanel = filtrPanel;
            FiltrDropown = filtrDropdown;
        }
    }
}
