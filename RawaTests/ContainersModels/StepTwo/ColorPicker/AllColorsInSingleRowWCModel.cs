using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class allColorsInSingleRowWCModel
    {
        private IWebDriver _driver;
        public List<SingleColorWCModel> allColorsInSingleRow { get; set; }
        public allColorsInSingleRowWCModel(IWebDriver driver)
        {
            this._driver = driver;
            allColorsInSingleRow = new List<SingleColorWCModel>();
        }
        public void GetRandomColor()
        {          
            Random random = new Random((int)DateTime.Now.Ticks);
            int r = random.Next(allColorsInSingleRow.Count);
            allColorsInSingleRow.ElementAt(r).SingleColor.ClickIfElementIsClickable(_driver);
        }
    }
}
