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
    class PanelCabinetsServices : BaseService
    {
        public PanelCabinetsServices() : base()
        {

        }
        //serwis który zwraca szafki dolne Eco
        public PanelCabinetsCollectionWCModel GetEcoLowerCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElement(By.XPath(CabinetsPanelLocator.bottomCabintesEco));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocator.ecoBottomId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomOpenCabinetsEco));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomClosedCabinetsEco));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomImagesOfCabinetsEco));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton,openCabintes,closedCabintes,imagesOfCabinets);

            return result;          
        }
        public PanelCabinetsCollectionWCModel GetEcoUpperCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElement(By.XPath(CabinetsPanelLocator.upperCabinetsEco));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocator.ecoUpperId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.upperOpenCabinetsEco));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.upperClosedCabinetsEco));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.upperImagesOfCabinetsEco));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        public PanelCabinetsCollectionWCModel GetSimplyLowerCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocator.bottomCabintesSimply));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocator.simplyBottomId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomOpenCabinetsSimply));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomClosedCabinetsSimply));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElementAndWait(By.XPath(CabinetsPanelLocator.bottomImagesOfCabinetsSimply));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        public PanelCabinetsCollectionWCModel GetSimplyUpperCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElement(By.XPath(CabinetsPanelLocator.bottomCabintesSimply));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocator.simplyUpperId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomOpenCabinetsSimply));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomClosedCabinetsSimply));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocator.bottomImagesOfCabinetsSimply));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        // servis do pola filtrowania
        public PanelCabinetFilterWCModel GetCabinetFilterPanel()
        {
            IWebElement filterButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocator.filterButton));
            IWebElement filterBodyColor = Manager.FindWebElement(By.XPath(CabinetsPanelLocator.filterBodyColor));
            IWebElement filterFrontType = Manager.FindWebElement(By.XPath(CabinetsPanelLocator.filterFrontType));

            PanelCabinetFilterWCModel result = new PanelCabinetFilterWCModel(filterButton, filterBodyColor, filterFrontType);

            return result;
            
        }
    }
}
