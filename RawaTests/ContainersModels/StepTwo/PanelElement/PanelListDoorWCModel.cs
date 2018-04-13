using RawaTests.WebElementsModels;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests.Services.StepTwoServices
{
    public class PanelListDoorWCModel
    {
        NxWELabelModel ListOfElements { get; set; }
        IList<NxWEImageModel> DoorList { get; set; }
        NxWELabelModel DoorProducent { get; set; }

        public  PanelListDoorWCModel(NxWELabelModel div, IList<NxWEImageModel> alalal, NxWELabelModel doorProducent )
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
