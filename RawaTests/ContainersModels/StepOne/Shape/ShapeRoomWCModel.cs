
using OpenQA.Selenium;

namespace RawaTests.Model
{
    public class ShapeRoomWCModel
    {
        // Nagłówek listy kształtów pomieszczeń
        public IWebElement Header { get; set; }
        // kształt pomieszczenia
        public IWebElement ShapeOfRoom { get; set; }
    }
}
