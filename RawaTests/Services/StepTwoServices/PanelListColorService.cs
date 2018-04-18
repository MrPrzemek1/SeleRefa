using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;

namespace RawaTests.Models.StepTwo
{
    class PanelListColorService : BaseService
    {
        public PanelListColorWCModel GetPanelListForColors()
        {
            var panel = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));

            PanelListColorWCModel panelElement = new PanelListColorWCModel(panel);
            return panelElement;
        }
    }
}
