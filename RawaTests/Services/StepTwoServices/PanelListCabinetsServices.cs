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
    class PanelListCabinetsServices : BaseService
    {
        public PanelListCabinetsWCModel GetCabinetPanel()
        {
            NxWELabelModel filtrPanel = new NxWELabelModel(Manager.FindWebElementAndWait(By.ClassName(CabinetsPanelLocator.filtrPanel)));
            var filtrButton = filtrPanel.FindElementAndWait<NxWEButtonModel>(By.XPath(CabinetsPanelLocator.filtrButton));
            var dropdowns = filtrPanel.FindElementsAndWait<NxWEButtonModel>((By.XPath(CabinetsPanelLocator.filtrDropdown)));
            NxWELabelModel CollectionGroup = new NxWELabelModel(Manager.FindWebElementAndWait(By.Id()));
        }
    }
}
