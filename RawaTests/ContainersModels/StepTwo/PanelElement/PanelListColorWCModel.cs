using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.Models.StepTwo
{
    public class PanelListColorWCModel : BaseWebContainerModel
    {
        public IWebElement PanelList { get; set; }

        public string Header { get { return PanelList.Text; } }

        public PanelListColorWCModel(IWebElement panel)
        {
            PanelList = panel;
        }

        public override bool IsValid()
        {
            return PanelList != null;
        }
    }
}
