using OpenQA.Selenium;
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

        public List<string> GetDoorId()
        {
            return DoorList.Select(e => e.GetAttribute("object-id")).ToList();
        }
    }
}
