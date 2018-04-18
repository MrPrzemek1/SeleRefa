using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Models.StepTwo.PanelElement;
using RawaTests.Services.Base;

namespace RawaTests.Services.StepTwoServices
{
    class PanelListWindowServices : BaseService
    {
        public PanelListWindowWCModel GetListForWindow()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));
            var windowImages = list.FindWebElements(By.XPath(StepTwoLocators.windowsImages));
            PanelListWindowWCModel panel = new PanelListWindowWCModel(list, windowImages);

            return panel;
        }
    }
}
