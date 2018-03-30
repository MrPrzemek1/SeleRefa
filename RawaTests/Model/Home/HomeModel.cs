using OpenQA.Selenium;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base;
using RawaTests.Model.Base.Buttons;

namespace RawaTests.Model
{
    abstract public class HomeModel : BaseModel
    {
        public INxButton StartButton { get; set; }
        public INxWebImage HomePageImage { get; set; }
        public INxWebImage LogoImage { get; set; }
        public NxWebText Footer { get; set;}
        public INxButton LoginBtn { get; set; }
    }
}
