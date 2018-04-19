using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo;
using RawaTests.HtmlStrings.ElementsLocators.StepTwo;
using RawaTests.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.StepTwoServices
{
    public class CanvasServices : BaseService
    {
        public CanvasWCModel GetCanvasModel()
        {
            IWebElement canvas = Manager.FindWebElement(By.XPath(CabinetsPanelLocator.canvas));
            CanvasWCModel model = new CanvasWCModel(canvas);
            return model;
        }
    }
}
