using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Models.StepTwo
{
    class PanelListColorService : BaseService
    {
        public PanelListColorWCModel GetPanelListForColors()
        {
            var panel = new NxWELabelModel(Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList)));

            PanelListColorWCModel panelElement = new PanelListColorWCModel(panel);
            return panelElement;
        }
    }
}
