using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo
{
    public class CanvasWCModel
    {
        IWebElement CanvasImage { get; set; }

        public CanvasWCModel(IWebElement canvasImage)
        {
            this.CanvasImage = canvasImage;
        }

        public IWebElement GetCanvas()
        {
            return this.CanvasImage;
        }
    }  
}
