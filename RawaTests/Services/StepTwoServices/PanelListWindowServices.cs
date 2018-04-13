using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Models.StepTwo.PanelElement;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Services.StepTwoServices
{
    class PanelListWindowServices : BaseService
    {
        public PanelListWindowWCModel GetListForWindow()
        {
            NxWELabelModel list = new NxWELabelModel(Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList)));
            var windowImages = list.FindElementsAndWait<NxWEImageModel>((By.XPath(StepTwoLocators.windowsImages)));
            PanelListWindowWCModel panel = new PanelListWindowWCModel(list, windowImages);

            return panel;
        }
    }
}
