using OpenQA.Selenium;
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

        public AllColorsInSingleRowWCModel()
        {
            allColorsInSingleRow = new List<SingleColorWCModel>();
        }
        public IWebElement GetRandomColor()
        {
            
            Random random = new Random((int)DateTime.Now.Ticks);
            int r = random.Next(allColorsInSingleRow.Count);
            return allColorsInSingleRow.ElementAt(r).SingleColor;
        }
    }
}
