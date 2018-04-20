using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;

namespace RawaTests.Models.StepTwo
{
    class PanelColorWCService : BaseService
    {
        public PanelColorWCModel GetPanelListForColors()
        {
            var panel = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));

            PanelColorWCModel panelElement = new PanelColorWCModel(panel);
            return panelElement;
        }
    }
}
