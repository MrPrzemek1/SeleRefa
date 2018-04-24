using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelDoorWCModel
    {
        IWebElement ListOfElements { get; set; }
        IList<IWebElement> DoorList { get; set; }
        IWebElement DoorProducent { get; set; }

        public  PanelDoorWCModel(IWebElement div, IList<IWebElement> alalal, IWebElement doorProducent )
        {
            ListOfElements = div;
            DoorList = alalal;
            DoorProducent = doorProducent; 
        }

        private List<string> GetDoorId()
        {
            return DoorList.Select(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID)).ToList();
        }
        public IWebElement GetRandomDoor()
        {
            List<string> doorList = GetDoorId();
            Random r = new Random();
            string randomList = doorList[r.Next(0, doorList.Count)];
            return DoorList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(randomList)).FirstOrDefault();
        }
    }
}
