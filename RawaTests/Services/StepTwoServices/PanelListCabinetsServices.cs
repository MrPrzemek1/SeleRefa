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
            var group = listOfCollection.FindElementsAndWait<NxWELabelModel>(By.XPath(CabinetsPanelLocator.collectionSub));

            foreach (var item in group)
            {
                var button2 = item.FindElementAndWait<NxWEButtonModel>(By.TagName("a"));

                var button = new NxWEButtonModel(Manager.FindWebElementAndWait(item.GetIWebElementElement(), By.TagName("a")));
                var categoryHelper = Manager.FindWebElementWithoutWait(item, By.XPath("//div[@aria-expanded]"));
                var category = Manager.FindWebElementsWithoutWait(categoryHelper, By.TagName("label"));

                PanelListCabinetsCollectionWCModel result = new PanelListCabinetsCollectionWCModel(group, group, images);
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
