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
            IWebElement header = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.headerClass));
            IWebElement image = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.imageClass)).FindWebElement(By.TagName("img"));
            IWebElement doorDimension = Manager.FindWebElement(By.XPath(ActiveDoorFormLocators.doorDimension));
            IWebElement deleteButton = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.deleteButton));

            ActiveDoorWCModel doorModel = new ActiveDoorWCModel(header, image, doorDimension, deleteButton);
            return doorModel;
        }
        #endregion
        #region Formularz aktywnego okna
        public ActiveWindowFullWCModel GetFullActiveWindowWCModel()
        {
            IWebElement header = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.formHeader));
            ActiveWindowRightTableWCModel rightTableWCModel = GetRightTableModel();
            ActiveWindowLeftTableWCModel leftTableWCModel = GetLeftTableModel();
            ActiveWindowFullWCModel activeWindowFullWCModel = new ActiveWindowFullWCModel(header, rightTableWCModel, leftTableWCModel);
            return activeWindowFullWCModel;
        }
        private ActiveWindowRightTableWCModel GetRightTableModel()
        {
            IWebElement bottomLocationHeader = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.bottomLocationHeader));
            IWebElement bottomLocationInput = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.bottomLocationInput));
            ActiveWindowRightTableWCModel rightModel = new ActiveWindowRightTableWCModel(bottomLocationHeader, bottomLocationInput);
            return rightModel;
        }
        private ActiveWindowLeftTableWCModel GetLeftTableModel()
        {
            IWebElement windowImage = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.windowImageThumb));
            IWebElement windowDimension = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.windowDimension));
            IWebElement deleteButton = Manager.FindWebElement(By.ClassName(ActiveWindowFormLocators.deleteWindowButton));
            ActiveWindowLeftTableWCModel leftModel = new ActiveWindowLeftTableWCModel(windowImage, windowDimension, deleteButton);
            return leftModel;
        }
        #endregion
        #region Formularz aktywnej szafki
        public ActiveCabinetFullWCModel GetActiveCabinetModel()
        {
            IWebElement panelHeader = Manager.FindWebElementAndWait(By.XPath(ActiveCabinetLocators.panelHeader));
            ActiveCabinetLeftTableWCModel leftPanel = GetLeftPanelWCModel();
            ActiveCabinetRightTableWCModel rightPanel = GetRightPanelWCModel();
            ActiveCabinetFullWCModel activeCabinetModel = new ActiveCabinetFullWCModel(panelHeader, rightPanel, leftPanel);
            return activeCabinetModel;
        }

        public ActiveCabinetRightTableWCModel GetRightPanelWCModel()
        {
            IWebElement rightPanelHelper = Manager.FindWebElement(By.ClassName(ActiveCabinetLocators.rightPanelHelper));
            IWebElement bottomLocation = rightPanelHelper.FindWebElement(By.Name(ActiveCabinetLocators.bottomLocation));
            IWebElement rotationInput = rightPanelHelper.FindWebElement(By.Name(ActiveCabinetLocators.rotationInput));
            IWebElement rotationDescendingButton = rightPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.rotationDescBtn));
            IWebElement rotationIncrementButton = rightPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.rotationIncBtn));
            ActiveCabinetRightTableWCModel rightPanelModel = new ActiveCabinetRightTableWCModel(bottomLocation, rotationInput, rotationDescendingButton, rotationIncrementButton);
            return rightPanelModel;
        }

        public ActiveCabinetLeftTableWCModel GetLeftPanelWCModel()
        {
            IWebElement leftPanelHelper = Manager.FindWebElement(By.ClassName(ActiveCabinetLocators.leftPanelHelper));
            IWebElement cabinetImage = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.cabinetImageThumb));
            IWebElement cabinetDimensionLabel = leftPanelHelper.FindWebElement(By.XPath(ActiveCabinetLocators.cabinetDimensionLabel));
            IWebElement deleteButton = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.deleteButton));
            IWebElement detailsButton = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocators.detailsButton));
            ActiveCabinetLeftTableWCModel leftPanelModel = new ActiveCabinetLeftTableWCModel(cabinetImage, cabinetDimensionLabel, deleteButton, detailsButton);
            return leftPanelModel;
        }
        #endregion
    }
}
