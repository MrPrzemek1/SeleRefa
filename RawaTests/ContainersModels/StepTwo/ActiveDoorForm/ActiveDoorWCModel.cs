using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo.ActiveDoorForm
{
    public class ActiveDoorWCModel : BaseWebContainerModel
    {
        public IWebElement header { get; set; }
        public IWebElement doorImageThumb { get; set; }
        public IWebElement doorDimension { get; set; }
        public IWebElement deleteButton { get; set; }

        public ActiveDoorWCModel(IWebElement header, IWebElement doorImageThumb, IWebElement doorDimension, IWebElement deleteButton)
        {
            this.header = header;
            this.doorImageThumb = doorImageThumb;
            this.doorDimension = doorDimension;
            this.deleteButton = deleteButton;
        }

        public override bool IsValid()
        {
            return header.Text.Contains(Configurator3DConsts.ACTIVEELEMENTHEADER) && doorImageThumb.GetAttributeSrc() != null && doorDimension.Text != null && deleteButton.Displayed;
        }
    }
}
