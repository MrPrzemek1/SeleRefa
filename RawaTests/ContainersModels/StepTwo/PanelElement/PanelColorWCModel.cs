using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.Models.StepTwo
{
    public class PanelColorWCModel : BaseWebContainerModel
    {
        public IWebElement panelList { get; set; }

        public string Header { get { return panelList.Text; } }

        public PanelColorWCModel(IWebElement panel)
        {
            panelList = panel;
        }

        public override bool IsValid()
        {
            return panelList != null;
        }
    }
}
