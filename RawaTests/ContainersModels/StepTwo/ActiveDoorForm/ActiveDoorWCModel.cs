using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.ContainersModels.StepTwo.ActiveDoorForm
{
    public class ActiveDoorWCModel : BaseWebContainerModel
    {
        public IWebElement Header { get; set; }
        public IWebElement DoorImageThumb { get; set; }
        public IWebElement DoorDimension { get; set; }
        public IWebElement DeleteButton { get; set; }

        public ActiveDoorWCModel(IWebElement header, IWebElement doorImageThumb, IWebElement doorDimension, IWebElement deleteButton)
        {
            Header = header;
            DoorImageThumb = doorImageThumb;
            DoorDimension = doorDimension;
            DeleteButton = deleteButton;
        }

        public override bool IsValid()
        {
            return Header.Text.Contains(Configurator3DConsts.ACTIVEELEMENTHEADER) && DoorImageThumb.GetAttributeSrc() != null && DoorDimension.Text != null && DeleteButton.Displayed;
        }
    }
}
