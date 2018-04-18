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
        //servis do pol z szafkami
        public PanelListCabinetsCollectionWCModel GetCabintesCollectionModel()
        {
            var listOfCollection = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocator.collectionGroup));
            IList<IWebElement> group = listOfCollection.FindWebElements(By.XPath(CabinetsPanelLocator.collectionSub));

            IList<IWebElement> list = new List<IWebElement>();
            
            foreach (var item in group)
            {          
                var button2 = item.FindWebElements(By.TagName("a"));

                var categoryHelper = item.FindWebElement(By.XPath("//div[@aria-expanded]"));
                var category = categoryHelper.FindWebElements(By.TagName("label"));
                
            }
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
