using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;
using System.Collections.Generic;
using System.Linq;

namespace RawaTests
{
    public class Room3DWCModel : BaseWebContainerModel
    {
        public IWebElement room3dImage { get; set; }
        public IList<IWebElement> room3dImageDimension { get; set; }

        public Room3DWCModel(IWebElement image, IList<IWebElement> imageDimension)
        {
            room3dImage = image;
            room3dImageDimension = imageDimension;
        }
        public override bool IsValid() => room3dImage != null;

        public string[] GetRoomDimension() => room3dImageDimension.Select(e => e.GetAttribute(HtmlAttributesConsts.STYLE)).ToArray();
    }
}
