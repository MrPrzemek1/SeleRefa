using OpenQA.Selenium;
using RawaTests.Helpers;

namespace RawaTests
{
    class Room3DViewModel
    {
        public IWebElement Room3DImage { get; set; }
        //public IWebElement DimensionSingleWall { get; set; }
        public Room3DViewModel()
        {
            Room3DImage = null;
        }
        public string Style { get { return Room3DImage.GetAttribute(HTMLConsts.STYLE); } }
    }

}
