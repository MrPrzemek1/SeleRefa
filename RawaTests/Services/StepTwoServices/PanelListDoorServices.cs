using OpenQA.Selenium;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.IWebElements.TextElements;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelListDoorServices : BaseService
    {
        public PanelListDoorModel GetPanelForDoors()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.doorPanelList));
            var doors = Manager.FindWebElementsAndWait(list, By.XPath(StepTwoLocators.doors));
            IWebElement doorProducent = Manager.FindWebElementWithoutWait(By.ClassName(StepTwoLocators.doorsProducent));

            PanelListDoorModel panelModel = new PanelListDoorModel(new NxLabels(list), doors, new NxLabels(doorProducent));
            return panelModel;
        }
    }
}
