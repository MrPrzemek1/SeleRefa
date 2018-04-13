using OpenQA.Selenium;
using RawaTests.Services.Base;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.WebElementsModels;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelListDoorServices : BaseService
    {
        public PanelListDoorModel GetPanelForDoors()
        {
            NxWELabelModel list = new NxWELabelModel(Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.doorPanelList)));
            var doors = list.FindElementsAndWait<NxWEImageModel>(By.XPath(StepTwoLocators.doorsImages));
            NxWELabelModel doorProducent = new NxWELabelModel(Manager.FindWebElementWithoutWait(By.ClassName(StepTwoLocators.doorsProducent)));

            PanelListDoorModel panelModel = new PanelListDoorModel(list, doors, doorProducent);

            return panelModel;
        }
    }
}
