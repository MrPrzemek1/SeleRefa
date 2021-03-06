﻿using OpenQA.Selenium;
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
            IWebElement canvas = _manager.FindWebElementAndWait(By.XPath(CabinetsPanelLocators.canvasLocator));
            CanvasWCModel model = new CanvasWCModel(_manager.Driver,canvas);
            return model;
        }
    }
}
