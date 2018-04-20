using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.Models.StepTwo
{
    public class PanelColorWCModel : BaseWebContainerModel
    {
        public IWebElement PanelList { get; set; }

        public string Header { get { return PanelList.Text; } }

        public PanelColorWCModel(IWebElement panel)
        {
            PanelList = panel;
        }

        public override bool IsValid()
        {
            return PanelList != null;
        }
    }
}
