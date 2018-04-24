using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using RawaTests.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo
{
    public class CanvasWCModel
    {
        public IWebElement CanvasImage { get; set; }

        public CanvasWCModel(IWebElement canvasImage)
        {
            CanvasImage = canvasImage;
        }

        public void OpenColorPickerOnCanvas()
        {
            Actions actions = new Actions(DriverManager.CreateInstance().Driver);
            actions.Click(CanvasImage).Perform();
            actions.SendKeys(Keys.Home).Perform();
                
        }
    }  
}
