using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelDoorWCModel
    {
        IWebElement divWithElements { get; set; }
        IList<IWebElement> doorList { get; set; }
        IWebElement doorProducent { get; set; }

        public  PanelDoorWCModel(IWebElement divWithElements, IList<IWebElement> doorList, IWebElement doorProducent )
        {
            this.divWithElements = divWithElements;
            this.doorList = doorList;
            this.doorProducent = doorProducent; 
        }

        private List<string> GetDoorId()
        {
            return doorList.Select(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID)).ToList();
        }
        public IWebElement GetRandomDoor()
        {
            List<string> doorsId = GetDoorId();
            Random r = new Random();
            string randomDoor = doorsId[r.Next(0, doorsId.Count)];
            return doorList.Where(e => e.GetAttribute(HtmlAttributesConsts.OBJECT_ID).Equals(randomDoor)).FirstOrDefault();
        }
    }
}
