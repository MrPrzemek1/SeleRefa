using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowLeftTableWCModel
    {
        public IWebElement WindowImage { get; set; }
        public IWebElement WindowDimension { get; set; }
        public IWebElement DeleteWindowButton { get; set; }

        public ActiveWindowLeftTableWCModel(IWebElement windowImage, IWebElement windowDimension, IWebElement deleteWindowButton)
        {
            WindowImage = windowImage;
            WindowDimension = windowDimension;
            DeleteWindowButton = deleteWindowButton;
        }

    }
}
