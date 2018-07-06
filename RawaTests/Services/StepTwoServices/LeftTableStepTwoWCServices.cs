using OpenQA.Selenium;
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
            IWebElement nameGroupOfCabintesButton = _manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.bottomCabintesEcoLocator));
            IWebElement cabinetsHelper = _manager.FindWebElement(By.Id(CabinetsPanelLocators.ecoBottomIdLocator));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomOpenCabinetsEcoLocator));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomClosedCabinetsEcoLocator));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomImagesOfCabinetsEcoLocator));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton,openCabintes,closedCabintes,imagesOfCabinets);

            return result;          
        }
        public PanelCabinetsCollectionWCModel GetEcoUpperCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = _manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.upperCabinetsEcoLocator));
            IWebElement cabinetsHelper = _manager.FindWebElement(By.Id(CabinetsPanelLocators.ecoUpperIdLocator));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.upperOpenCabinetsEcoLocator));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.upperClosedCabinetsEcoLocator));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.upperImagesOfCabinetsEcoLocator));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        public PanelCabinetsCollectionWCModel GetSimplyLowerCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = _manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.bottomCabintesSimplyLocator));
            IWebElement cabinetsHelper = _manager.FindWebElement(By.Id(CabinetsPanelLocators.simplyBottomIdLocator));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomOpenCabinetsSimplyLocator));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomClosedCabinetsSimplyLocator));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElementAndWait(_manager.Driver,By.XPath(CabinetsPanelLocators.bottomImagesOfCabinetsSimplyLocator));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        public PanelCabinetsCollectionWCModel GetSimplyUpperCabintesModel()
        {
            IWebElement nameGroupOfCabintesButton = _manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.bottomCabintesSimplyLocator));
            IWebElement cabinetsHelper = _manager.FindWebElement(By.Id(CabinetsPanelLocators.simplyUpperIdLocator));
            IWebElement openCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomOpenCabinetsSimplyLocator));
            IWebElement closedCabintes = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomClosedCabinetsSimplyLocator));
            IWebElement imagesOfCabinets = cabinetsHelper.FindWebElement(By.XPath(CabinetsPanelLocators.bottomImagesOfCabinetsSimplyLocator));

            PanelCabinetsCollectionWCModel result = new PanelCabinetsCollectionWCModel(nameGroupOfCabintesButton, openCabintes, closedCabintes, imagesOfCabinets);

            return result;
        }
        // servis do pola filtrowania
        public PanelCabinetFilterWCModel GetCabinetFilterPanel()
        {
            IWebElement filterButton = _manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.filterButtonLocator));
            IWebElement filterBodyColor = _manager.FindWebElement(By.XPath(CabinetsPanelLocators.filterBodyColorLocator));
            IWebElement filterFrontType = _manager.FindWebElement(By.XPath(CabinetsPanelLocators.filterFrontTypeLocator));

            PanelCabinetFilterWCModel result = new PanelCabinetFilterWCModel(filterButton, filterBodyColor, filterFrontType);

            return result;        
        }
        public PanelColorWCModel GetPanelForColors()
        {
            var panel = _manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelListLocator));

            PanelColorWCModel panelElement = new PanelColorWCModel(panel);
            return panelElement;
        }
        public PanelWindowWCModel GetPanelForWindow()
        {
            IWebElement list = _manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelListLocator));
            var windowImages = list.FindWebElements(_manager.Driver,By.XPath(StepTwoLocators.windowsImagesLocator));
            PanelWindowWCModel panel = new PanelWindowWCModel(list, windowImages);

            return panel;
        }
        public PanelDoorWCModel GetPanelForDoors()
        {
            IWebElement list = _manager.FindWebElementAndWait(By.XPath(StepTwoLocators.doorPanelListLocator));
            var doors = list.FindWebElements(_manager.Driver,By.XPath(StepTwoLocators.doorsImagesLocator));
            IWebElement doorProducent = _manager.FindWebElement(By.ClassName(StepTwoLocators.doorsProducentLocator));

            PanelDoorWCModel panelModel = new PanelDoorWCModel(list, doors, doorProducent);

            return panelModel;
        }
    }
}
