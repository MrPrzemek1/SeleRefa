using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelDoorWCModel
    {
        IWebElement DivWithElements { get; set; }
        IList<IWebElement> DoorList { get; set; }
        IWebElement DoorProducent { get; set; }

        public  PanelDoorWCModel(IWebElement divWithElements, IList<IWebElement> doorList, IWebElement doorProducent )
        {
            DivWithElements = divWithElements;
            DoorList = doorList;
            DoorProducent = doorProducent; 
        }

        private List<string> GetDoorId()
        {
            return DoorList.Select(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID)).ToList();
        }
        public IWebElement GetRandomDoor()
        {
            List<string> doorsId = GetDoorId();
            Random r = new Random();
            string randomDoor = doorsId[r.Next(0, doorsId.Count)];
            return DoorList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(randomDoor)).FirstOrDefault();
        }
    }
}
