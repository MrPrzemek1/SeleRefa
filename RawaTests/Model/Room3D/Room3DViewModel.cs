using OpenQA.Selenium;
using RawaTests.Helpers;
using RawaTests.IWebElements;

namespace RawaTests
{
    class Room3DViewModel
    {
        public INxWebImage Room3DImage { get; set; }
        //public IWebElement DimensionSingleWall { get; set; }
        public Room3DViewModel()
        {
            Room3DImage = null;
        }
    }

}
