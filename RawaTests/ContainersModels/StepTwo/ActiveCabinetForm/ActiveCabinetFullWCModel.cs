using OpenQA.Selenium;
using RawaTests.ContainersModels.StepTwo.ActiveElement;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo
{
    public class ActiveCabinetFullWCModel : BaseWebContainerModel
    {
        IWebElement header { get; set; }
        public ActiveCabinetRightTableWCModel rightPanel { get; set; }
        public ActiveCabinetLeftTableWCModel leftPanel { get; set; }

        public ActiveCabinetFullWCModel(IWebElement header, ActiveCabinetRightTableWCModel right, ActiveCabinetLeftTableWCModel left)
        {
            this.header = header;
            leftPanel = left;
            rightPanel = right;
        }
        public string HeaderText{ get { return header.Text; } }

        public override bool IsValid() => HeaderText.Contains(Configurator3DConsts.ACTIVECABINETSHEADER) && rightPanel != null && leftPanel != null;
    }
}
