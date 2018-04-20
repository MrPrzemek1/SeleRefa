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
            IWebElement panelHeader = Manager.FindWebElementAndWait(By.XPath(ActiveCabinetLocator.panelHeader));
            ActiveCabinetLeftTableWCModel leftPanel = GetLeftPanelWCModel();
            ActiveCabinetRightTableWCModel rightPanel = GetRightPanelWCModel();
            ActiveCabinetFullWCModel activeCabinetModel = new ActiveCabinetFullWCModel(panelHeader, rightPanel, leftPanel);
            return activeCabinetModel;
        }

        public ActiveCabinetRightTableWCModel GetRightPanelWCModel()
        {
            IWebElement rightPanelHelper = Manager.FindWebElement(By.ClassName(ActiveCabinetLocator.rightPanelHelper));
            IWebElement bottomLocation = rightPanelHelper.FindWebElement(By.Name(ActiveCabinetLocator.bottomLocation));
            IWebElement rotationInput = rightPanelHelper.FindWebElement(By.Name(ActiveCabinetLocator.rotationInput));
            IWebElement rotationDescendingButton = rightPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocator.rotationDescBtn));
            IWebElement rotationIncrementButton = rightPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocator.rotationIncBtn));
            ActiveCabinetRightTableWCModel rightPanelModel = new ActiveCabinetRightTableWCModel(bottomLocation,rotationInput,rotationDescendingButton,rotationIncrementButton);
            return rightPanelModel;
        }

        public ActiveCabinetLeftTableWCModel GetLeftPanelWCModel()
        {
            IWebElement leftPanelHelper = Manager.FindWebElement(By.ClassName(ActiveCabinetLocator.leftPanelHelper));
            IWebElement cabinetImage = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocator.cabinetImageThumb));
            IWebElement cabinetDimensionLabel = leftPanelHelper.FindWebElement(By.XPath(ActiveCabinetLocator.cabinetDimensionLabel));
            IWebElement deleteButton = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocator.deleteButton));
            IWebElement detailsButton = leftPanelHelper.FindWebElement(By.ClassName(ActiveCabinetLocator.detailsButton));
            ActiveCabinetLeftTableWCModel leftPanelModel = new ActiveCabinetLeftTableWCModel(cabinetImage, cabinetDimensionLabel, deleteButton, detailsButton);
            return leftPanelModel;
        }
    }
}
