﻿using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.PanelElement;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using RawaTests.Models.StepTwo;
using RawaTests.Models.StepTwo.PanelElement;
using RawaTests.Managers;

namespace RawaTests.Services.StepTwoServices.PanelListForCabinets
{
    class LeftTableStepTwoWCServices : BaseService
    {
        public LeftTableStepTwoWCServices(DriverManager manager) : base(manager) { }

        //serwis który zwraca szafki dolne Eco
        public PanelCabinetsCollectionWCModel GetEcoLowerCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.bottomCabintesEco));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocators.ecoBottomId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomOpenCabinetsEco));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomClosedCabinetsEco));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomImagesOfCabinetsEco));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton,openCabintes,closedCabintes,imagesOfCabinets);

            return result;          
        }
        public PanelCabinetsCollectionWCModel GetEcoUpperCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.upperCabinetsEco));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocators.ecoUpperId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.upperOpenCabinetsEco));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.upperClosedCabinetsEco));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.upperImagesOfCabinetsEco));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        public PanelCabinetsCollectionWCModel GetSimplyLowerCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.bottomCabintesSimply));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocators.simplyBottomId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomOpenCabinetsSimply));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomClosedCabinetsSimply));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElementAndWait(Manager.Driver,By.XPath(CabinetsPanelLocators.bottomImagesOfCabinetsSimply));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        public PanelCabinetsCollectionWCModel GetSimplyUpperCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.bottomCabintesSimply));
            IWebElement cabinetsHelper = Manager.FindWebElement(By.Id(CabinetsPanelLocators.simplyUpperId));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomOpenCabinetsSimply));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomClosedCabinetsSimply));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomImagesOfCabinetsSimply));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        // servis do pola filtrowania
        public PanelCabinetFilterWCModel GetCabinetFilterPanel()
        {
            IWebElement filterButton = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.filterButton));
            IWebElement filterBodyColor = Manager.FindWebElement(By.XPath(CabinetsPanelLocators.filterBodyColor));
            IWebElement filterFrontType = Manager.FindWebElement(By.XPath(CabinetsPanelLocators.filterFrontType));

            PanelCabinetFilterWCModel result = new PanelCabinetFilterWCModel(filterButton, filterBodyColor, filterFrontType);

            return result;        
        }
        public PanelColorWCModel GetPanelForColors()
        {
            var panel = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));

            PanelColorWCModel panelElement = new PanelColorWCModel(panel);
            return panelElement;
        }
        public PanelWindowWCModel GetPanelForWindow()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));
            var windowImages = list.FindWebElements(Manager.Driver,By.XPath(StepTwoLocators.windowsImages));
            PanelWindowWCModel panel = new PanelWindowWCModel(list, windowImages);

            return panel;
        }
        public PanelDoorWCModel GetPanelForDoors()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.doorPanelList));
            var doors = list.FindWebElements(Manager.Driver,By.XPath(StepTwoLocators.doorsImages));
            IWebElement doorProducent = Manager.FindWebElement(By.ClassName(StepTwoLocators.doorsProducent));

            PanelDoorWCModel panelModel = new PanelDoorWCModel(list, doors, doorProducent);

            return panelModel;
        }
    }
}
