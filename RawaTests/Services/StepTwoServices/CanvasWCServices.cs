using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Managers;
using RawaTests.Services.Base;

namespace RawaTests.Services.StepTwoServices
{
    public class CanvasWCServices : BaseService
    {
        public CanvasWCServices(DriverManager manager) : base(manager) { }

        public CanvasWCModel GetCanvasModel()
        {
            IWebElement canvas = Manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.canvas));
            CanvasWCModel model = new CanvasWCModel(Manager.Driver,canvas);
            return model;
        }
    }
}
