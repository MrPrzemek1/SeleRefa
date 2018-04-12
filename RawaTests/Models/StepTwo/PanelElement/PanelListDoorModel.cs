using OpenQA.Selenium;
using RawaTests.IWebElements;
using RawaTests.WebElements.TextElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelListDoorModel
    {
        INxLabels ListOfElements { get; set; }
        IList<IWebElement> DoorList { get; set; }
        INxLabels DoorProducent { get; set; }

        public  PanelListDoorModel(INxLabels div, IList<IWebElement> alalal,INxLabels doorProducent )
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
