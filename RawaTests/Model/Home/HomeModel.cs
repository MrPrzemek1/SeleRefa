using OpenQA.Selenium;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.Model.Base;
using RawaTests.Model.Base.Buttons;
using RawaTests.WebElements.TextElements;

namespace RawaTests.Model
{
    abstract public class HomeModel : BaseModel
    {
        public INxButton StartButton { get; set; }
        public INxWebImage HomePageImage { get; set; }
        public INxWebImage LogoImage { get; set; }
        public INxWebText Footer { get; set;}
        public INxButton LoginBtn { get; set; }
        public INxWebText Header { get; set; }
        public INxWebText Logout { get; set; }
    }
}
