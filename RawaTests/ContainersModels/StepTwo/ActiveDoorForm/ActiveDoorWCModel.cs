using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.ContainersModels.StepTwo.ActiveDoorForm
{
    public class ActiveDoorWCModel
    {
        public IWebElement Header { get; set; }
        public IWebElement DoorImageThumb { get; set; }
        public IWebElement DoorDimension { get; set; }
        public IWebElement DeleteButton { get; set; }

        public ActiveDoorWCModel(IWebElement header, IWebElement doorImageThumb, IWebElement doorDimension, IWebElement deleteButton)
        {
            Header = header;
            DoorImageThumb = doorImageThumb;
            DoorDimension = doorDimension;
            DeleteButton = deleteButton;
        }
    }
}
