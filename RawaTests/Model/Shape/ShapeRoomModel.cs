using OpenQA.Selenium;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.WebElements.TextElements;

namespace RawaTests.Model
{
    public class ShapeRoomModel
    {
        public INxLabels Header { get; set; }
        public INxWebImage ShapeOfRoom { get; set; }
    }
}
