using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class AllColorsInSingleRowWCModel
    {
        public List<SingleColorWCModel> allColorsInSingleRow { get; set; }
        private IWebDriver Driver;
        public AllColorsInSingleRowWCModel(IWebDriver driver)
        {
            this.Driver = driver;
            allColorsInSingleRow = new List<SingleColorWCModel>();
        }
        public void GetRandomColor()
        {          
            Random random = new Random((int)DateTime.Now.Ticks);
            int r = random.Next(allColorsInSingleRow.Count);
            allColorsInSingleRow.ElementAt(r).SingleColor.ClickIfElementIsClickable(Driver);
        }
    }
}
