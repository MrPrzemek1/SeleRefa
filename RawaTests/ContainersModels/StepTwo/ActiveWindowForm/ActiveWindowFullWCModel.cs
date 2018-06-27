using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo.ActiveWindowForm
{
    public class ActiveWindowFullWCModel : BaseWebContainerModel
    {
        public IWebElement Header { get; set; }
        public ActiveWindowRightTableWCModel RightTableWCModel { get; set; }
        public ActiveWindowLeftTableWCModel LeftTableWCModel { get; set; }

        public ActiveWindowFullWCModel(IWebElement header, ActiveWindowRightTableWCModel rightTableWCModel, ActiveWindowLeftTableWCModel leftTableWCModel)
        {
            Header = header;
            RightTableWCModel = rightTableWCModel;
            LeftTableWCModel = leftTableWCModel;
        }

        public override bool IsValid()
        {
            return Header.Text.Contains(Configurator3DConsts.ACTIVEELEMENTHEADER) && RightTableWCModel != null && LeftTableWCModel != null;
        }
    }
}
