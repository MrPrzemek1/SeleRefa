using OpenQA.Selenium;
using RawaTests.Model.Base;
using System.Collections.Generic;

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
        //public string[] GetRoomDimension()
        //{
        //    return Room3dImage.Select(e => e.Room3dImage.GetAttribute(HtmlAttributesConsts.STYLE)).ToArray();
        //}
    }

}
