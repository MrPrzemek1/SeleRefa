using RawaTests.Model.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Models.StepTwo
{
    public class PanelListColorWCModel : BaseWebContainerModel
    {
        public NxWELabelModel PanelList { get; set; }

        public string Header { get { return PanelList.Text; } }

        public PanelListColorWCModel(NxWELabelModel panel)
        {
            PanelList = panel;
        }

        public override bool IsValid()
        {
            return PanelList != null;
        }
    }
}
