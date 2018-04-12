using RawaTests.Model.Base;
using RawaTests.WebElements.TextElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawaTests.Models.StepTwo
{
    public class PanelElementColorModel : BaseModel
    {
        public INxLabels PanelList { get; set; }

        public string Header { get { return PanelList.Text; } }

        public PanelElementColorModel(INxLabels panel)
        {
            PanelList = panel;
        }

        public override bool IsValid()
        {
            return PanelList != null;
        }
    }
}
