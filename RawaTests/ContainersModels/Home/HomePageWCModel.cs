using OpenQA.Selenium;
using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model.Base;

namespace RawaTests.Model
{
    public class HomePageWCModel : BaseWebContainerModel
    {
        public IWebElement StartButton { get; set; }
        public IWebElement HomePageImage { get; set; }
        public IWebElement LogoImage { get; set; }
        public IWebElement Footer { get; set;}
        public IWebElement LoginBtn { get; set; }
        public IWebElement Header { get; set; }
        public IWebElement LogoutDiv { get; set; }
        public IWebElement LogoutButton { get; set; }
    

    public HomePageWCModel(IWebElement startBtn, IWebElement homeImg, IWebElement logoImg, IWebElement footer, IWebElement loginBtn, IWebElement header, IWebElement logoutDiv, IWebElement logoutBtn)
    {
        StartButton = startBtn;
        HomePageImage = homeImg;
        LogoImage = logoImg;
        Footer = footer;
        LoginBtn = loginBtn;
        Header = header;
        LogoutDiv = logoutDiv;
        LogoutButton = logoutBtn;
    }
    public override bool IsValid()
    {
        return StartButton.Displayed && HomePageImage.GetAttributeSrc() != null && Footer.Text.Equals(Configurator3DConsts.FOOTER) && Header.Text.Equals(Configurator3DConsts.HEADER);
    }
    }
}
