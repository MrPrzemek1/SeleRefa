using OpenQA.Selenium;
using RawaTests.IWebElements.TextElements;
using RawaTests.WebElements.TextElements;

namespace RawaTests.Model
{
    public class ShapeRoomModel
    {
        public INxLabels Header { get; set; }
        public IWebElement ShapeOfRoom { get; set; }
    }
}
