using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelDoorWCServices : BaseService
    {
        public PanelDoorWCModel GetPanelForDoors()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.doorPanelList));
            var doors = list.FindWebElements(By.XPath(StepTwoLocators.doorsImages));
            IWebElement doorProducent = Manager.FindWebElement(By.ClassName(StepTwoLocators.doorsProducent));

            PanelDoorWCModel panelModel = new PanelDoorWCModel(list, doors, doorProducent);

            return panelModel;
        }
    }
}
