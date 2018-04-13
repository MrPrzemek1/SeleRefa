using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Models.StepTwo.PanelElement;
using RawaTests.Services.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Services.StepTwoServices
{
    class PanelListWindowServices : BaseService
    {
        public PanelListWindowModel GetListForWindow()
        {
            NxWELabelModel list = new NxWELabelModel(Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList)));
            var windowImages = list.FindElementsAndWait<NxWEImageModel>((By.XPath(StepTwoLocators.windowsImages)));
            PanelListWindowModel panel = new PanelListWindowModel(list, windowImages);

            return panel;
        }
    }
}
