using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements;
using RawaTests.WebElements.TextElements;
using RawaTests.HtmlStrings.ConstStrings;
namespace RawaTests.Model.Home
{
    class HomePageModel : HomeModel
    {
        public HomePageModel(INxButton startBtn, INxImage homeImg, INxImage logoImg, INxLabels footer, INxButton loginBtn, INxLabels header, INxLabels logoutDiv, INxButton logoutBtn)
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
            return StartButton.Dispalyed() && HomePageImage.GetElementAttribute("src") != null && Footer.Text.Equals(FooterAndHeader.FOOTER) && Header.Text.Equals(FooterAndHeader.HEADER);
        }
    }
}
