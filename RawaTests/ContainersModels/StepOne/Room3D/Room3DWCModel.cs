using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests
{
    public class Room3DWCModel : BaseWebContainerModel
    {
        public IWebElement Room3dImage { get; set; }

        public override bool IsValid()
        {
            return Room3dImage != null;
        }
    }

}
