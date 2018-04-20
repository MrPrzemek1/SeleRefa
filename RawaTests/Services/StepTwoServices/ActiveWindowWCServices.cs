using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.ActiveWindowForm;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.StepTwoServices
{
    public class ActiveWindowWCServices : BaseService
    {
        public ActiveWindowFullWCModel GetFullActiveWindowWCModel()
        {
            IWebElement header = Manager.FindWebElement(By.XPath(ActiveWindowFormLocators.formHeader));
            ActiveWindowRightTableWCModel rightTableWCModel = GetRightTableModel();
            ActiveWindowLeftTableWCModel leftTableWCModel = GetLeftTableModel();
            ActiveWindowFullWCModel activeWindowFullWCModel = new ActiveWindowFullWCModel(header, rightTableWCModel,leftTableWCModel);
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
            ActiveWindowLeftTableWCModel leftModel = new ActiveWindowLeftTableWCModel(windowImage,windowDimension,deleteButton);
            return leftModel;
        }
    }
    
}
