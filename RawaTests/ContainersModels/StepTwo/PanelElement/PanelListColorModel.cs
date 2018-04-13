using RawaTests.Model.Base;
using RawaTests.WebElementsModels;

namespace RawaTests.Models.StepTwo
{
    public class PanelListColorModel : BaseWebContainerModel
    {
        public NxWELabelModel PanelList { get; set; }

        public string Header { get { return PanelList.Text; } }

        public PanelListColorModel(NxWELabelModel panel)
        {
            PanelList = panel;
        }

        public override bool IsValid()
        {
            return PanelList != null;
        }
    }
}
