using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelListDoorWCModel
    {
        IWebElement ListOfElements { get; set; }
        IList<IWebElement> DoorList { get; set; }
        IWebElement DoorProducent { get; set; }

        public  PanelListDoorWCModel(IWebElement div, IList<IWebElement> alalal, IWebElement doorProducent )
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
