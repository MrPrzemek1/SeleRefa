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

namespace RawaTests.Services.StepTwoServices.PanelListForCabinets
{
    class PanelListCabinetsServices : BaseService
    {
        //servis do pol z szafkami
        public PanelListCabinetsCollectionWCModel GetCabintesCollectionModel()
        {
            var listOfCollection = new NxWEButtonModel(Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocator.collectionGroup)));
            var group = listOfCollection.FindElementsAndWait<NxWEButtonModel>(By.XPath(CabinetsPanelLocator.SzafkiSimplyDolneGrupy));

            foreach (var item in group)
            {
                var images = item.FindElementsAndWait<NxWEImageModel>(By.XPath(CabinetsPanelLocator.cabinetImages));
                PanelListCabinetsCollectionWCModel result = new PanelListCabinetsCollectionWCModel(listOfCollection, group, images);
                return result;
            }
            return null;
        }
        // servis do pola filtrowania
        public PanelListCabinetsFilterWCModel GetCabinetFilterPanel()
        {
            NxWELabelModel filtrPanel = new NxWELabelModel(Manager.FindWebElementAndWait(By.ClassName(CabinetsPanelLocator.filtrPanel)));
            List<NxWEButtonModel> dropdowns = filtrPanel.FindElementsAndWait<NxWEButtonModel>((By.XPath(CabinetsPanelLocator.filtrDropdown)));

            PanelListCabinetsFilterWCModel result = new PanelListCabinetsFilterWCModel(filtrPanel, dropdowns);

            return result;
        }
    }
}
