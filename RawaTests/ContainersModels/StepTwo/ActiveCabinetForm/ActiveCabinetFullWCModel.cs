using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.ActiveElement;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo
{
    public class ActiveCabinetFullWCModel : BaseWebContainerModel
    {
        IWebElement Header { get; set; }
        public ActiveCabinetRightTableWCModel RightPanel { get; set; }
        public ActiveCabinetLeftTableWCModel LeftPanel { get; set; }

        public ActiveCabinetFullWCModel(IWebElement header, ActiveCabinetRightTableWCModel right, ActiveCabinetLeftTableWCModel left)
        {
            Header = header;
            LeftPanel = left;
            RightPanel = right;
        }
        public string HeaderText{ get { return Header.Text; } }

        public override bool IsValid() => HeaderText.Contains(Configurator3DConsts.ACTIVECABINETSHEADER) && RightPanel != null && LeftPanel != null;
    }
}
