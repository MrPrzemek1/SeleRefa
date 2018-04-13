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
            NxWEButtonModel filtrButton = filtrPanel.FindElementAndWait<NxWEButtonModel>(By.XPath(CabinetsPanelLocator.filtrButton));
            List<NxWEButtonModel> dropdowns = filtrPanel.FindElementsAndWait<NxWEButtonModel>((By.XPath(CabinetsPanelLocator.filtrDropdown)));
            NxWELabelModel collectionGroup = new NxWELabelModel(Manager.FindWebElementAndWait(By.Id(CabinetsPanelLocator.collectionGroup)));
            List<NxWEButtonModel> subGroup = collectionGroup.FindElementsAndWait<NxWEButtonModel>(By.ClassName(CabinetsPanelLocator.collectionSubGroup));
            List<NxWEImageModel> images = collectionGroup.FindElementsAndWait<NxWEImageModel>(By.XPath(CabinetsPanelLocator.cabinetImages));

            PanelListCabinetsWCModel result = new PanelListCabinetsWCModel(filtrPanel,filtrButton,dropdowns,collectionGroup,subGroup,images);
            return result;
        }
    }
}
