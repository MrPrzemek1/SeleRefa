using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.PanelElement;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.StepTwoServices
{
    class PanelListCabinetsFilterServices : BaseService
    {
        public PanelListCabinetsFilterWCModel GetCabinetFilterPanel()
        {
            NxWELabelModel filtrPanel = new NxWELabelModel(Manager.FindWebElementAndWait(By.ClassName(CabinetsPanelLocator.filtrPanel)));
            List<NxWEButtonModel> dropdowns = filtrPanel.FindElementsAndWait<NxWEButtonModel>((By.XPath(CabinetsPanelLocator.filtrDropdown)));
          
            PanelListCabinetsFilterWCModel result = new PanelListCabinetsFilterWCModel(filtrPanel, dropdowns);            

            return result;
        }
    }
}
