using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.ContainersModels.StepTwo.ActiveDoorForm;
using RawaTests.ContainersModels.StepTwo.ActiveElement;
using RawaTests.ContainersModels.StepTwo.ActiveWindowForm;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Managers;
using RawaTests.Services.Base;

namespace RawaTests.Services.StepTwoServices
{
    class ActiveElementFormWCServices : BaseService
    {
        public ActiveElementFormWCServices(DriverManager manager) : base(manager) { }

        #region Formularz aktywnych drzwi        
        public ActiveDoorWCModel GetActiveDoorForm()
        {
            IWebElement header = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.headerLocator));
            IWebElement image = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.imageLocator)).FindWebElement(By.TagName("img"));
            IWebElement doorDimension = Manager.FindWebElement(By.XPath(ActiveDoorFormLocators.doorDimensionLocator));
            IWebElement deleteButton = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.deleteButtonLocator));

            ActiveDoorWCModel doorModel = new ActiveDoorWCModel(header, image, doorDimension, deleteButton);
            return doorModel;
        }
        #endregion
        #region Formularz aktywnego okna
        public ActiveWindowFullWCModel GetFullActiveWindowWCModel()
        {
            IWebElement header = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.formHeaderLocator));
            ActiveWindowRightTableWCModel rightTableWCModel = GetRightTableModel();
            ActiveWindowLeftTableWCModel leftTableWCModel = GetLeftTableModel();
            ActiveWindowFullWCModel activeWindowFullWCModel = new ActiveWindowFullWCModel(header, rightTableWCModel, leftTableWCModel);
            return activeWindowFullWCModel;
        }
        private ActiveWindowRightTableWCModel GetRightTableModel()
        {
            IWebElement bottomLocationHeader = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.bottomLocationHeaderLocator));
            IWebElement bottomLocationInput = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.bottomLocationInputLocator));
            ActiveWindowRightTableWCModel rightModel = new ActiveWindowRightTableWCModel(bottomLocationHeader, bottomLocationInput);
            return rightModel;
        }
        private ActiveWindowLeftTableWCModel GetLeftTableModel()
        {
            IWebElement windowImage = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.windowImageThumbLocator));
            IWebElement windowDimension = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.windowDimensionLocator));
            IWebElement deleteButton = Manager.FindWebElement(By.ClassName(ActiveWindowFormLocators.deleteWindowButtonLocator));
            ActiveWindowLeftTableWCModel leftModel = new ActiveWindowLeftTableWCModel(windowImage, windowDimension, deleteButton);
            return leftModel;
        }
        #endregion
        #region Formularz aktywnej szafki
        public ActiveCabinetFullWCModel GetActiveCabinetModel()
        {
            IWebElement panelHeader = Manager.FindWebElementAndWait(By.XPath(ActiveCabinetLocators.panelHeaderLocator));
            ActiveCabinetLeftTableWCModel leftPanel = GetLeftPanelWCModel();
            ActiveCabinetRightTableWCModel rightPanel = GetRightPanelWCModel();
            ActiveCabinetFullWCModel activeCabinetModel = new ActiveCabinetFullWCModel(panelHeader, rightPanel, leftPanel);
            return activeCabinetModel;
        }

        public ActiveCabinetRightTableWCModel GetRightPanelWCModel()
        {
            IWebElement rightPanelHelper = Manager.FindWebElement(By.ClassName(ActiveCabinetLocators.rightPanelHelperLocator));
            IWebElement bottomLocation = rightPanelHelper.FindWebElement(By.Name(ActiveCabinetLocators.bottomLocationLocator));
            IWebElement rotationInput = rightPanelHelper.FindWebElement(By.Name(ActiveCabinetLocators.rotationInputLocator));
            IWebElement rotationDescendingButton = rightPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.rotationDescButtonLocator));
            IWebElement rotationIncrementButton = rightPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.rotationIncButtonLocator));
            ActiveCabinetRightTableWCModel rightPanelModel = new ActiveCabinetRightTableWCModel(bottomLocation, rotationInput, rotationDescendingButton, rotationIncrementButton);
            return rightPanelModel;
        }

        public ActiveCabinetLeftTableWCModel GetLeftPanelWCModel()
        {
            IWebElement leftPanelHelper = Manager.FindWebElement(By.ClassName(ActiveCabinetLocators.leftPanelHelperLocator));
            IWebElement cabinetImage = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.cabinetImageThumbLocator));
            IWebElement cabinetDimensionLabel = leftPanelHelper.FindWebElement(By.XPath(ActiveCabinetLocators.cabinetDimensionLabelLocator));
            IWebElement deleteButton = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.deleteButtonLocator));
            IWebElement detailsButton = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.detailsButtonLocator));
            ActiveCabinetLeftTableWCModel leftPanelModel = new ActiveCabinetLeftTableWCModel(cabinetImage, cabinetDimensionLabel, deleteButton, detailsButton);
            return leftPanelModel;
        }
        #endregion
    }
}
