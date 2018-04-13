using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Models.StepTwo
{
    class PanelListColorService : BaseService
    {
        public PanelListColorModel GetPanelListForColors()
        {
            var panel = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));

            PanelListColorModel panelElement = new PanelListColorModel(new NxWELabelModel(panel));
            return panelElement;
        }
    }
}
