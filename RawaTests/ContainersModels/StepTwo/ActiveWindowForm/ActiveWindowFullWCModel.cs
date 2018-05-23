using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowFullWCModel : BaseWebContainerModel
    {
        public IWebElement header { get; set; }
        public ActiveWindowRightTableWCModel rightTableWCModel;
        public ActiveWindowLeftTableWCModel leftTableWCModel;

        public ActiveWindowFullWCModel(IWebElement header, ActiveWindowRightTableWCModel rightTableWCModel, ActiveWindowLeftTableWCModel leftTableWCModel)
        {
            this.header = header;
            this.rightTableWCModel = rightTableWCModel;
            this.leftTableWCModel = leftTableWCModel;
        }

        public override bool IsValid()
        {
            return header.Text.Contains(Configurator3DConsts.ACTIVEELEMENTHEADER) && rightTableWCModel != null && leftTableWCModel != null;
        }
    }
}
