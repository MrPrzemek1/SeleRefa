using OpenQA.Selenium;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ColorPicker
{
    public class AllColorsInSingleRowWCModel
    {
        public List<SingleColorWCModel> allColorsInSingleRow { get; set; }
        private DriverManager Manager;
        public AllColorsInSingleRowWCModel()
        {
            allColorsInSingleRow = new List<SingleColorWCModel>();
        }
        public void GetRandomColor()
        {
           
            Random random = new Random((int)DateTime.Now.Ticks);
            int r = random.Next(allColorsInSingleRow.Count);
            allColorsInSingleRow.ElementAt(r).SingleColor.ClickIfElementIsClickable(Manager.Driver);
        }
    }
}
