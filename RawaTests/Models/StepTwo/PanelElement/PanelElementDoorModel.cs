using RawaTests.IWebElements;
using RawaTests.WebElements.TextElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Models.StepTwo.PanelElement
{
    public class PanelElementDoorModel
    {
        INxImage PanelDetails { get; set; }
        PanelElementColorModel PanelSimple { get; set; }

        public PanelElementDoorModel(INxImage image)
        {
            
        }
    }
}
