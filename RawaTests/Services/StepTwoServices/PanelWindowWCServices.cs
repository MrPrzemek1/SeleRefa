using OpenQA.Selenium;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Models.StepTwo.PanelElement;
using RawaTests.Services.Base;

namespace RawaTests.Services.StepTwoServices
{
    class PanelWindowWCServices : BaseService
    {
        public PanelWindowWCModel GetListForWindow()
        {
            IWebElement list = Manager.FindWebElementAndWait(By.XPath(StepTwoLocators.panelList));
            var windowImages = list.FindWebElements(By.XPath(StepTwoLocators.windowsImages));
            PanelWindowWCModel panel = new PanelWindowWCModel(list, windowImages);

            return panel;
        }
    }
}
