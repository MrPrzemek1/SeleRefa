using RawaTests.HtmlStrings.ConstStrings;
using RawaTests.Model;
using RawaTests.WebElementsModels;

namespace RawaTests.ContainersModels.Home
{
    class ActionOnWCHomePage : HomePageWCModel
    {
        public ActionOnWCHomePage(NxWEButtonModel startBtn, NxWEImageModel homeImg, NxWEImageModel logoImg, NxWELabelModel footer, NxWEButtonModel loginBtn, NxWELabelModel header, NxWELabelModel logoutDiv, NxWEButtonModel logoutBtn)
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
