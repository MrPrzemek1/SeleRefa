using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests
{
    public class Room3DWCModel : BaseWebContainerModel
    {
        public IWebElement Room3dImage { get; set; }
        public IList<IWebElement> Room3dImageDimension { get; set; }

        public Room3DWCModel(IWebElement image, IList<IWebElement> imageDimension)
        {
            Room3dImage = image;
            Room3dImageDimension = imageDimension;
        }
        public override bool IsValid()
        {
            return Room3dImage != null;
        }
        public string[] GetRoomDimension()
        {
            return Room3dImageDimension.Select(e => e.GetAttribute(HtmlAttributesConsts.STYLE)).ToArray();
        }
    }

}
