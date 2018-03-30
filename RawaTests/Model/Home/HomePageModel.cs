using RawaTests.Model.Base.Buttons;
using RawaTests.IWebElements;
using RawaTests.IWebElements.TextElements;
using RawaTests.WebElements.TextElements;

namespace RawaTests.Model.Home
{
    class HomePageModel : HomeModel
    {
        public HomePageModel(INxButton startBtn, INxWebImage homeImg, INxWebImage logoImg, INxWebText footer, INxButton loginBtn, INxWebText header, INxWebText logout)
        {
            StartButton = startBtn;
            HomePageImage = homeImg;
            LogoImage = logoImg;
            Footer = footer;
            LoginBtn = loginBtn;
            Header = header;
            Logout = logout;
        }
        public override bool IsValid()
        {
            return StartButton != null && HomePageImage.GetImageSource() != null;
        }
        
    }
}
