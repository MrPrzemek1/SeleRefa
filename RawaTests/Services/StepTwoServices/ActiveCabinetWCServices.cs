using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.ContainersModels.StepTwo.ActiveElement;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services
{
    public class ActiveCabinetWCServices : BaseService
    {
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
            ActiveCabinetRightTableWCModel rightPanelModel = new ActiveCabinetRightTableWCModel(bottomLocation,rotationInput,rotationDescendingButton,rotationIncrementButton);
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
    }
}
