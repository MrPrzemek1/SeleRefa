using OpenQA.Selenium;

namespace RawaTests.Model
{
    public class ShapeRoomModel
    {
        public IWebElement ShapeOfRoom { get; set; }

        public string Id
        {
            get
            {
                return ShapeOfRoom.GetAttribute("shape-id");
            }
        }


    }
}
