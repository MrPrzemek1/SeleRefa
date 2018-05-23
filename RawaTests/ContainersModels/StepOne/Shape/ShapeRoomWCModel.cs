using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.Model
{
    public class ShapeRoomWCModel : BaseWebContainerModel
    {
        // Nagłówek listy kształtów pomieszczeń
        public IWebElement header { get; set; }
        // kształt pomieszczenia
        public IWebElement shapeOfRoom { get; set; }

        public override bool IsValid() => header != null && header.Text.Contains(Configurator3DConsts.CHOOSEROOMHEADER) && shapeOfRoom != null;
    }
}
