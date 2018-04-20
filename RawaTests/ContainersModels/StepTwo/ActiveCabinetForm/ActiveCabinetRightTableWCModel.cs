using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ActiveElement
{
    public class ActiveCabinetRightTableWCModel
    {
            public IWebElement BottomLocation { get; set; }
            public IWebElement RotationInput { get; set; }
            public IWebElement RotationButtonDesc { get; set; }
            public IWebElement RotationButtonInc { get; set; }

            public ActiveCabinetRightTableWCModel(IWebElement bottomLocation, IWebElement rotationInput, IWebElement rotationButtonDesc, IWebElement rotationButtonInc)
            {
                BottomLocation = bottomLocation;
                RotationInput = rotationInput;
                RotationButtonDesc = rotationButtonDesc;
                RotationButtonInc = rotationButtonInc;
            }
    }
}
