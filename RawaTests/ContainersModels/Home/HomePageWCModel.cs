using OpenQA.Selenium;
using RawaTests.Model.Base;

namespace RawaTests.Model
{
    abstract public class HomePageWCModel : BaseWebContainerModel
    {
        public IWebElement StartButton { get; set; }
        public IWebElement HomePageImage { get; set; }
        public IWebElement LogoImage { get; set; }
        public IWebElement Footer { get; set;}
        public IWebElement LoginBtn { get; set; }
        public IWebElement Header { get; set; }
        public IWebElement LogoutDiv { get; set; }
        public IWebElement LogoutButton { get; set; }
    }
}
