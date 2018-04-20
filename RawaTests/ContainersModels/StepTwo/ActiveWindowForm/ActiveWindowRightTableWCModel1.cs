using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowRightTableWCModel
    {
        public IWebElement BottomLocationHeader { get; set; }
        public IWebElement BottomLocationInput { get; set; }

        public ActiveWindowRightTableWCModel(IWebElement bottomLocationHeader, IWebElement bottomLocationInput)
        {
            BottomLocationHeader = bottomLocationHeader;
            BottomLocationInput = bottomLocationInput;
        }
    }

}
