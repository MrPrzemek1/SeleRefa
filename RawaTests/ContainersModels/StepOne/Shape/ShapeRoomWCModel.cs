using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.Model
{
    public class ShapeRoomWCModel : BaseWebContainerModel
    {
        // Nagłówek listy kształtów pomieszczeń
        public IWebElement Header { get; set; }
        // kształt pomieszczenia
        public IWebElement ShapeOfRoom { get; set; }

        public override bool IsValid()
        {
            return Header != null && Header.Text.Contains(Configurator3DConsts.CHOOSEROOMHEADER) && ShapeOfRoom != null;
        }
    }
}
