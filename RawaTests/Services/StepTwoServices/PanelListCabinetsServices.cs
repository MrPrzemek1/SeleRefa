using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.PanelElement;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RawaTests.Services.Base;

namespace RawaTests.Services.StepTwoServices.PanelListForCabinets
{
    class PanelListCabinetsServices : BaseService
    {
        public PanelListCabinetsServices() : base()
        {

        }
        //servis do pol z szafkami
        public PanelListCabinetsCollectionWCModel GetCabintesCollectionModel()
        {
            var listOfCollection = Manager.FindWebElementAndWait(By.Id(CabinetsPanelLocator.collectionGroup));
            IList<IWebElement> group = listOfCollection.FindWebElements(By.XPath(CabinetsPanelLocator.collectionSub));
            var szafkiDolne = listOfCollection.FindWebElements(By.XPath("//a[@href]"));
            
            var szafki = szafkiDolne.Where() szafkiGrupa.FindWebElements(By.TagName("label"));
            var image = szafkiGrupa.FindWebElements(By.ClassName("furnitures-items"));

            PanelListCabinetsCollectionWCModel result = new PanelListCabinetsCollectionWCModel(szafkiDolne, szafki, image);
            return result;
            
        }
        // servis do pola filtrowania
        public PanelListCabinetsFilterWCModel GetCabinetFilterPanel()
        {
            IWebElement filtrPanel = Manager.FindWebElementAndWait(By.ClassName(CabinetsPanelLocator.filtrPanel));
            IList<IWebElement> dropdowns = filtrPanel.FindWebElements(By.XPath(CabinetsPanelLocator.filtrDropdown));

            PanelListCabinetsFilterWCModel result = new PanelListCabinetsFilterWCModel(filtrPanel, dropdowns);

            return result;
        }
    }
}
