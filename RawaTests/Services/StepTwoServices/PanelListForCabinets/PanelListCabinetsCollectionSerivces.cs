using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.PanelElement;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.WebElementsModels;
using RawaTests.Helpers.DriverHelper;
using RawaTests.ContainersModels.StepTwo.PanelElement.PanelElementForCabinets;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;

namespace RawaTests.Services.StepTwoServices
{
    class PanelListCabinetsCollectionSerivces : BaseService
    {
        public PanelListCabinetsCollectionWCModel GetCollectionModel()
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

        
    }
}
