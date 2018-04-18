using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelListDoorServices : BaseService
    {
        public PanelListDoorWCModel GetPanelForDoors()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.doorPanelList));
            var doors = list.FindWebElements(By.XPath(StepTwoLocators.doorsImages));
            IWebElement doorProducent = Manager.FindWebElement(By.ClassName(StepTwoLocators.doorsProducent));

            PanelListDoorWCModel panelModel = new PanelListDoorWCModel(list, doors, doorProducent);

            return panelModel;
        }
    }
}
