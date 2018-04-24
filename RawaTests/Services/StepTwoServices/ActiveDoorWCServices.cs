using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.ActiveDoorForm;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.StepTwoServices
{
    public class ActiveDoorWCServices : BaseService
    {
        public ActiveDoorWCModel GetActiveDoorForm()
        {
            IWebElement header = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.headerClass));
            IWebElement image = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.imageClass)).FindWebElement(By.TagName("img"));
            IWebElement doorDimension = Manager.FindWebElement(By.XPath(ActiveDoorFormLocators.doorDimension));
            IWebElement deleteButton = Manager.FindWebElement(By.ClassName(ActiveDoorFormLocators.deleteButton));

            ActiveDoorWCModel doorModel = new ActiveDoorWCModel(header, image, doorDimension, deleteButton);
            return doorModel;
        }
    }
}
