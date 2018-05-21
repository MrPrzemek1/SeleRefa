using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowFullWCModel : BaseWebContainerModel
    {
        public IWebElement Header { get; set; }
        public ActiveWindowRightTableWCModel rightTableWCModel;
        public ActiveWindowLeftTableWCModel leftTableWCModel;

        public ActiveWindowFullWCModel(IWebElement header, ActiveWindowRightTableWCModel rightTableWCModel, ActiveWindowLeftTableWCModel leftTableWCModel)
        {
            Header = header;
            this.rightTableWCModel = rightTableWCModel;
            this.leftTableWCModel = leftTableWCModel;
        }

        public override bool IsValid()
        {
            return Header.Text.Contains(Configurator3DConsts.ACTIVEELEMENTHEADER) && rightTableWCModel != null && leftTableWCModel != null;
        }
    }
}
